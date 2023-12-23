using Exams_Application.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Data.Models
{
    public class User : BaseEntity
    {
        public string? Password { get; set; }
        public string? PhoneNum { get; set; }
        public Roles Role { get; set; }
        public string? FullName { get; set; }
        //how to say that base.Name is UserName here?

    }



}