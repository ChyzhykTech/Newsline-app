using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Threading.Tasks;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.BLL.Services;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;
using static Thread_.NET.Mail.Smtp.SmtpOptions;

namespace Thread_.NET.Mail.Services
{
    public class EmailService : BaseService
    {
		private readonly UserService _userService;
		private readonly AuthService _authService;

		public EmailService(ThreadContext context, UserService userService, AuthService authService) : base(context) 
		{
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

		public void SendPostByEmail(SharePostByEmailDTO sharePost)
		{
			if (sharePost.Post == null)
			{
				throw new NotFoundException("Post was not found");
			}
			var link = $"http://localhost:4200/thread?postId={sharePost.Post.Id}";
			var message = GetAbstractMimeMessage();
			message.To.Add(new MailboxAddress(sharePost.Email, sharePost.Email));
			message.Subject = "Share post";

			message.Body = new TextPart("plain")
			{
				Text = $"Your recived link to post. Click ---->    {link}"
			};

			SendMail(message);
		}

		private async Task<User> GetUserByPostId(int postId) => await _userService.GetUserEntityByPostId(postId);

		private async Task<User> GetUserById(int userId) => await _userService.GetUserEntityById(userId);

		private MimeMessage GetAbstractMimeMessage()
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress(GetAuthor(), GetEmail()));
			return message;
		}

		private void SendMail(MimeMessage message)
		{
			using (var client = new SmtpClient()) 
			{
				client.Connect(GetSmtp(), GetPort(), true);
				client.Authenticate(GetEmail(), GetSmtpPassword());
				client.Send(message);
				client.Disconnect(true);
			}			
		}
    }
}
