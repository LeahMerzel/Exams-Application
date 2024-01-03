using AutoMapper;
using Exams_Application.Core.DTOs;
using Exams_Application.Core.Interfaces;
using Exams_Application.Data.DB;
using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Exams_Application.Core.Repositories
{
    public class AuthRepository : GenericRepository<User>, IAuthRepository
    {
        private readonly IMapper _mapper;
        private User? _user;
        private readonly UserManager<User> _manager;
        private readonly IConfiguration _config;

        private const string _loginProvider = "TutApi";
        private const string _refreshToken = "RefreshToken";

        public AuthRepository(
            IMapper mapper,
            ExamsDbContext db,
            UserManager<User> _manager,
            IConfiguration config
        ) : base(db)
        {
            _mapper = mapper;
            this._manager = _manager;
            _config = config;
        }

        public async Task<UserTokenDTO?> Login(UserLoginDTO loginDto)
        {
            //_logger.LogInformation($"Looking for user '{loginVM.Email}'");
            _user = await _manager.FindByEmailAsync(loginDto.Email);
            bool isValid = await _manager.CheckPasswordAsync(_user, loginDto.Password);

            if (_user == null || !isValid)
            {
                //_logger.LogWarning($"user with email '{loginDto.Email}' was not found!!!");
                return null;
            }
            var token = await GenerateToken();
            UserTokenDTO userReturn = new()
            {
                Token = token,
                UserId = _user.Id,
                RefreshToken = await CreateRefreshToken()
            };
            //_logger.LogInformation($"Generated token: {token}\nfor user: {loginDto.Email}");

            return userReturn;
        }

        public async Task<string> CreateRefreshToken()
        {
            await _manager.RemoveAuthenticationTokenAsync
                (_user!, _loginProvider, _refreshToken);
            var newRefreshToken = await _manager.GenerateUserTokenAsync
                (_user!, _loginProvider, _refreshToken);
            var result = await _manager.SetAuthenticationTokenAsync
                (_user!, _loginProvider, _refreshToken, newRefreshToken);
            return newRefreshToken;
        }

        public async Task<IEnumerable<IdentityError>> Register(UserRegisterDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            var res = await _manager.CreateAsync(user, userDTO.Password);

            if (res.Succeeded)
            {
                await _manager.AddToRoleAsync(user, "User");
            }

            return res.Errors;
        }

        public async Task<bool> UpdateUser(UserUpdateDTO user)
        {
            _user = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email);

            if (_user == null)
            {
                return false;
            }

            try
            {
                UpdateUserDetails(user);
                dbContext.Entry(_user).State = EntityState.Modified;
                await dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return true;
        }

        private async Task<string> GenerateToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this is my amazing very Secret key for authentication"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await _manager.GetRolesAsync(_user);
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            var userClaims = await _manager.GetClaimsAsync(_user);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, _user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, _user.Email),
                new Claim("uid", _user.Id.ToString()),
            }.Union(userClaims).Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: "TutApi",
                audience: "TutApiClient",
                claims: claims,
                expires: DateTime.Now.AddDays(2),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<UserTokenDTO?> VerifyRefreshToken(UserTokenDTO request)
        {

            var jsonSecurityTokeHandler = new JwtSecurityTokenHandler();
            var tokenContent = jsonSecurityTokeHandler.ReadJwtToken(request.Token);
            var userEmail = tokenContent.Claims.ToList()
                .FirstOrDefault(e => e.Type == JwtRegisteredClaimNames.Email)?.Value;

            _user = await _manager.FindByEmailAsync(userEmail);

            if (_user == null)
            {
                return null;
            }

            var isValidRefreshToken = await _manager.VerifyUserTokenAsync
                (_user, _loginProvider, _refreshToken, request.RefreshToken);

            if (isValidRefreshToken)
            {
                var token = await GenerateToken();
                return new UserTokenDTO
                {
                    Token = token,
                    UserId = _user.Id,
                    RefreshToken = await CreateRefreshToken()
                };
            }
            await _manager.UpdateSecurityStampAsync(_user);
            return null;
        }

        public void UpdateUserDetails(UserUpdateDTO user)
        {
            _user!.UserName = user.UserName;
            _user.Role = user.Role;
            _user.Password = user.Password;
            _user.PhoneNum = user.PhoneNum;
            _user.Email = user.NewEmail;
            _user.FullName = user.FullName;
            _user.CreatedAt = user.CreatedAt;
        }

        public async Task<UserReturnDto?> GetUser(Guid UserId)
        {
            return _mapper.Map<UserReturnDto>(await dbContext.Users.SingleOrDefaultAsync(u => u.Id == UserId));
        }
    }
}
