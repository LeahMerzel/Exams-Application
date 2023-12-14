using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Student: User
    {
        public DateTime EnrolementDate { get; set; }
        public List<Course>? StudentsCourses { get; set; }
        public List<StudentExam>? StudentsTakenExams { get; set; }
        public float GradeAvg { get; set; }

    }
}
