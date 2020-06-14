export interface UserResetPasswordDto {
    userId: number;
    oldPassword: string;
    newPassword: string;
    confirmPassword: string;
    confirmToken: string;
}