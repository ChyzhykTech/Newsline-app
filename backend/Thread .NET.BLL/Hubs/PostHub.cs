using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
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
      
        public async Task SendPostLike()
        {
            var fromUserId = Context.User.Claims.FirstOrDefault(x => x.Type == "id")?.Value;
            var userDTO = await _userService.GetUserById(int.Parse(fromUserId));
            await Clients.All.SendAsync("PostLike", userDTO);
        }

        //For debug
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("Notify", $"{Context.ConnectionId} вошел в чат");
            await base.OnConnectedAsync();
        }
    }
}
