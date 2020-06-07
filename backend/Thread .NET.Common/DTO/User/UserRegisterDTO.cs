using System.ComponentModel.DataAnnotations;

namespace Thread_.NET.Common.DTO.User
{
    public sealed class UserRegisterDTO : UserDTO
    {
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
