using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Student: User
    {
        public DateTime EnrolementDate { get; set; }
        public List<Course>? StudentsCourses { get; set; }
        public Dictionary<string, int>? ExamsTakenAndGrades { get; set; }//when student submits exam
                                                                         //the grade and examName
                                                                         //are pushed in to this Dictionary
        public float GradeAvg { get; set; }

    }
}
