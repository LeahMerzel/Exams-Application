using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

public interface IAuthService
{
    Task<SignInResult> LoginAsync(string username, string password);
    Task LogoutAsync();
}