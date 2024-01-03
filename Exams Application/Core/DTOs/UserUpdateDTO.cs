using Exams_Application.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Core.DTOs
{
    public class UserUpdateDTO : UserMainDTO
    {
        [Required]
        [EmailAddress]
        public string NewEmail { get; set; }
        [Required]
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FullName { get; set; }
        public string? Password { get; set; }
        public string? PhoneNum { get; set; }
        public Enums.Roles Role { get; set; }
    }
}
