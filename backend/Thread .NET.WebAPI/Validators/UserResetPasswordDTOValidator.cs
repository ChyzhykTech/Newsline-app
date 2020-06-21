using FluentValidation;
using Thread_.NET.Common.DTO.User;

namespace Thread_.NET.Validators
{
    public sealed class UserResetPasswordDTOValidator : AbstractValidator<UserResetPasswordDTO>
    {
        public UserResetPasswordDTOValidator()
        { 
            RuleFor(u => u.OldPassword).NotNull();
            RuleFor(u => u.NewPassword).Length(4, 16);
            RuleFor(u => u.ConfirmPassword).Equal(u => u.NewPassword);
        }
        
    }
}
