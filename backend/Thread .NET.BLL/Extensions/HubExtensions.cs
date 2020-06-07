using Microsoft.AspNetCore.SignalR;
using System.Linq;
using Thread_.NET.BLL.Exceptions;

namespace Thread_.NET.BLL.Extensions
{
    public static class HubExtensions
    {
        public static int GetUserIdFromToken(this Hub hub)
        {
            var claimsUserId = hub.Context.User.Claims.FirstOrDefault(x => x.Type == "id")?.Value;

            if (string.IsNullOrEmpty(claimsUserId))
            {
                throw new InvalidTokenException("access");
            }

            return int.Parse(claimsUserId);
        }
    }
}
