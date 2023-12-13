using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? PhoneNum { get; set; }
        public bool IsAdmin { get; set; }
        public string? FullName { get; set; }
        public DateTime UserCreated { get; set; }


    }
}