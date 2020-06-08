using System.ComponentModel.DataAnnotations;

namespace Thread_.NET.Common.DTO.User
{
    public class UserDTO
    {
        public int Id { get; set; }
        
        [Required]
        public string Avatar { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
       
        [Required]
        [MinLength(6)]
        [MaxLength(20)]
        public string UserName { get; set; }
    }
}
