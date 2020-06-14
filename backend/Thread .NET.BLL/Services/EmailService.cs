using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;
using Thread_.NET.BLL.Extensions;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public class EmailService : BaseService
    {
		private readonly PostService _postService;
		private readonly UserService _userService;
		private readonly AuthService _authService;

		public EmailService(ThreadContext context, PostService postService, UserService userService, AuthService authService) : base(context) 
		{
			_postService = postService;
			_userService = userService;
			_authService = authService;
		}

        public async Task SendLikeMessageToEmail(int postId, int userId)
        {
			var toUser = await GetUserByPostId(postId);
			var fromUser = await GetUserById(userId);
			var message = GetAbstractMimeMessage();
			message.To.Add(new MailboxAddress(toUser.UserName, toUser.Email));
			message.Subject = "Like message";

			message.Body = new TextPart("plain")
			{
				Text = $"Hello! User {fromUser.UserName} liked your post with id: {postId}!"
			};

			SendMail(message);
		}

		public async Task SendResetPasswordLinkToEmail(int userId, string uri)
		{
			var user = await _userService.GetUserEntityById(userId);
			var token = await _authService.GeneratePasswordResetToken(user.Id);
			var parameters = $"?token={token}";
			var message = GetAbstractMimeMessage();
			message.To.Add(new MailboxAddress(user.UserName, user.Email));
			message.Subject = "Reset password";

			message.Body = new TextPart("plain")
			{
				Text = $"Click link for reset your password {uri + parameters}"
			};
			SendMail(message);
		}

		private async Task<User> GetUserByPostId(int postId) => await _userService.GetUserEntityByPostId(postId);

		private async Task<User> GetUserById(int userId) => await _userService.GetUserEntityById(userId);

		private MimeMessage GetAbstractMimeMessage()
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress(this.GetAuthor(), this.GetEmail()));
			return message;
		}

		private void SendMail(MimeMessage message)
		{
			using var client = new SmtpClient();
			client.Connect(this.GetSmtp(), this.GetPort(), true);
			client.Authenticate(this.GetEmail(), this.GetSmtpPassword());
			client.Send(message);
			client.Disconnect(true);
		}
    }
}
