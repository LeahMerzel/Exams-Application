using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Student: User
    {

        [NotMapped]//dateonly didnt work for db
        public DateOnly EnrolementDate { get; set; }
        public List<Exam>? ExamsToDo { get; set; }
        public float GradeAvg { get; set; }
        public List<Exam> AllExamsTaken { get; set;}

    }
}
