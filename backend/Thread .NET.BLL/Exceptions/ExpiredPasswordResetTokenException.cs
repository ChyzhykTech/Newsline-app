using System;

namespace Thread_.NET.BLL.Exceptions
{
    public sealed class ExpiredPasswordResetTokenException : Exception
    {
        public ExpiredPasswordResetTokenException() : base("Password reset token expired.") { }
    }
}
