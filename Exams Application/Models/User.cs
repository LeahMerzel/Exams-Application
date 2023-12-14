using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Models
{
    public class User: BaseEntity
    {
        public string? Password { get; set; }
        public string? PhoneNum { get; set; }
        public bool IsAdmin { get; set; }
        public string? FullName { get; set; }
        //how to say that base.Name is UserName here?

    }
}