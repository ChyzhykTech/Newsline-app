using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Extensions;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.Post;

namespace Thread_.NET.BLL.Hubs
{
    [Authorize]
    public sealed class PostHub : Hub
    {
        private readonly UserService _userService;

        public PostHub(UserService userService)
        {
            _userService = userService;
        }

        public async Task Send(PostDTO post)
        {
            await Clients.All.SendAsync("NewPost", post);
        }
      
        public async Task SendLike(string connectionId, int postId)
        {
            var fromUserId = this.GetUserIdFromToken();
            var fromUserDTO = await _userService.GetUserById(fromUserId);
            await Clients.Client(connectionId).SendAsync("LikePost", fromUserDTO, postId);
        }

        public override async Task OnConnectedAsync()
        {
            var userId = this.GetUserIdFromToken();
            var connectionId = Context.ConnectionId;           
            await Clients.All.SendAsync("Notify", userId, connectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception ex)
        {
            await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId);
            await base.OnDisconnectedAsync(ex);
        }
    }
}
