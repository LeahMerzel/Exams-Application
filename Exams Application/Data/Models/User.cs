namespace Exams_Application.Data.Models
{
    public class User : BaseEntity
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNum { get; set; }
        public Enums.Enums.Roles Role { get; set; }
        //how to say that base.Name is UserName here?
        public string? Email { get; set; }

    }



}