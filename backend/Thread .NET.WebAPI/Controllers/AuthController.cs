using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.User;
using Thread_.NET.Extensions;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        private readonly EmailService _emailService;

        public AuthController(AuthService authService, EmailService emailService)
        {
            _authService = authService;
            _emailService = emailService;
        }
     
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<AuthUserDTO>> Login(UserLoginDTO dto)
        {
            return Ok(await _authService.Authorize(dto));
        }

        //[HttpGet("password/reset")]
        //[AllowAnonymous]
        //public async Task<ActionResult> Reset(string token)
        //{

        //}

        [HttpPost("password/forgot")]
        public async Task<ActionResult> ForgotPassword()
        {
            var userId = this.GetUserIdFromToken();
            var protocol = Request.IsHttps ? "https" : "http";
            var uri = $"{protocol}://{Request.Host.Host + Request.Host.Port}/api/auth/password/reset";
            await _emailService.SendResetPasswordLinkToEmail(userId, uri);
            return Ok();
        }
    }
}