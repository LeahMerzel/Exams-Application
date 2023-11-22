using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Student: User
    {
        public DateTime EnrolementDate { get; set; }
        public ICollection<Teacher>? StudentsTeachers { get; set; }
        public ICollection<Exam>? ExamsToDo { get; set; } 
        public List<ExamStudent>? AllExamsTaken { get; set;}
        public float GradeAvg { get; set; }

    }
}
