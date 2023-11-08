using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Teacher: User
    {

        [NotMapped]
        public DateOnly HireDate { get; set; }
        public List<Student> TeachersStudents { get; set; }
        public List<Exam> AllTeachersExams { get; set; }
        public List<Exam> SubmitedExams { get; set; }
    }
}
