using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Data.Models
{
    public class Student : User
    {
        public DateTime EnrolementDate { get; set; }
        public List<Course>? StudentsCourses { get; set; }
        public List<StudentExam>? StudentsTakenExams { get; set; }
        public float GradeAvg { get; set; }
        public Student()
        {
            StudentsCourses = new List<Course>();
            StudentsTakenExams = new List<StudentExam>();
        }
    }
}
