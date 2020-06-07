using System.ComponentModel.DataAnnotations;

namespace Thread_.NET.Common.DTO.User
{
    public sealed class UserLoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
