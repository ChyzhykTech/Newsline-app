using System;

namespace Thread_.NET.BLL.Exceptions
{
    public class InvalidPasswordResetTokenException : Exception
    {
        public InvalidPasswordResetTokenException() : base("Invalid password reset token.") { }
    }
}
