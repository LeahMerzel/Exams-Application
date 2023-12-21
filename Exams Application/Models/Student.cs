using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Student: User
    {
        public DateTime EnrolementDate { get; set; }
        public List<Course>? StudentsCourses { get; set; } = new List<Course>();
        public List<StudentExam>? StudentsTakenExams { get; set; } = new List<StudentExam>();
        public float GradeAvg { get; set; }

    }
}
