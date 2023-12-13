using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Exams_Application.Interfaces;

namespace Exams_Application.Services
{
    public class AuthService : IAuthService//how come its not using my folder Interfaces?
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IHttpContextAccessor httpContextAccessor;

        public AuthService(SignInManager<IdentityUser> signInManager, IHttpContextAccessor httpContextAccessor)
        {
            this.signInManager = signInManager;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<SignInResult> LoginAsync(string username, string password)
        {
            var result = await signInManager.PasswordSignInAsync(username, password, false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                // Simulate setting a cookie upon successful login
                await httpContextAccessor.HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }, CookieAuthenticationDefaults.AuthenticationScheme))
                );
            }

            return result;
        }

        public async Task LogoutAsync()
        {
            // Simulate clearing the authentication cookie
            await httpContextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }

}
