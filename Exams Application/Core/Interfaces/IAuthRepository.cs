using Exams_Application.Core.DTOs;
using Microsoft.AspNetCore.Identity;

namespace Exams_Application.Core.Interfaces
{
    public interface IAuthRepository
    {
        Task<IEnumerable<IdentityError>> Register(UserRegisterDTO user);
        Task<UserTokenDTO?> Login(UserLoginDTO user);
        Task<string> CreateRefreshToken();
        Task<bool> UpdateUser(UserUpdateDTO user);
        Task<UserTokenDTO?> VerifyRefreshToken(UserTokenDTO request);
        Task<UserReturnDto?> GetUser(string UserId);
    }
}
