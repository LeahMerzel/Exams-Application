using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Core.DTOs
{
    public abstract class UserMainDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
