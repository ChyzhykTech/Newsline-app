using System;
using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public sealed class PasswordResetToken : BaseEntity
    {
        private const int HOURS_TO_EXPIRE = 1;

        public PasswordResetToken()
        {
            Expires = DateTime.UtcNow.AddHours(HOURS_TO_EXPIRE);
        }

        public string Token { get; set; }
        public DateTime Expires { get; private set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsActive => DateTime.UtcNow <= Expires;
    }
}
