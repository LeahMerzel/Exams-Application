using Exams_Application.Core.DTOs;
using Microsoft.AspNetCore.Identity;

namespace Exams_Application.Core.Repositories
{
    public interface IAuthRepository
    {
        Task<string> CreateRefreshToken();
        Task<UserReturnDto?> GetUser(Guid UserId);
        Task<UserTokenDTO?> Login(UserLoginDTO loginDto);
        Task<IEnumerable<IdentityError>> Register(UserRegisterDTO userDTO);
        Task<bool> UpdateUser(UserUpdateDTO user);
        void UpdateUserDetails(UserUpdateDTO user);
        Task<UserTokenDTO?> VerifyRefreshToken(UserTokenDTO request);
    }
}