using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Teacher: User
    {
        public DateTime HireDate { get; set; }
        public List<Course>? TeachersCourses { get; set; }
        public List<Exam>? AllTeachersExams { get; set; }
    }
}
