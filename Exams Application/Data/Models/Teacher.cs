using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Data.Models
{
    public class Teacher : User
    {
        public DateTime HireDate { get; set; }
        public List<Course>? TeachersCourses { get; set; }
        public List<Exam>? AllTeachersExams { get; set; }
        public Teacher()
        {
            TeachersCourses = new List<Course>();
            AllTeachersExams = new List<Exam>();
        }

    }
}
