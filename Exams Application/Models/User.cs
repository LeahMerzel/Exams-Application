using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Models
{
    public class User
    {
        //how do i auto increment
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? PhoneNum { get; set; }
        public bool IsAdmin { get; set; }
        public string? FullName { get; set; }

        public User() 
        {
        }

        protected User(int id, string? userName, string? password, string? phoneNum, bool isAdmin, string? fullName)
        {
            Id = id;
            UserName = userName;
            Password = password;
            PhoneNum = phoneNum;
            IsAdmin = isAdmin;
            FullName = fullName;
        }
    }
}