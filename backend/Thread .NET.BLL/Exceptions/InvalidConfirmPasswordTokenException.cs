using System;

namespace Thread_.NET.BLL.Exceptions
{
    public sealed class InvalidConfirmPasswordTokenException : Exception
    {
        public InvalidConfirmPasswordTokenException() : base("Invalid confirm password token exception.") { }
    }
}
