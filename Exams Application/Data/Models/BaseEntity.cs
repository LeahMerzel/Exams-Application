using Microsoft.AspNetCore.Identity;

namespace Exams_Application.Data.Models
{
    public class BaseEntity: IdentityUser
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
