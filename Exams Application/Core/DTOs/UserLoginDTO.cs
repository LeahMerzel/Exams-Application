using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Core.DTOs
{
    public class UserLoginDTO : UserMainDTO
    {
        [Required]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to {1} characters", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
