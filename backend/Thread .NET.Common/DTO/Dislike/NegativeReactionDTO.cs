using Thread_.NET.Common.DTO.User;

namespace Thread_.NET.Common.DTO.Dislike
{
    class NegativeReactionDTO
    {
        public bool IsDislike { get; set; }
        public UserDTO User { get; set; }
    }
}
