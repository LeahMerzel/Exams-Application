namespace Exams_Application.Core.DTOs
{
    public class UserTokenDTO
    {
        public Guid UserId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
