using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Student: User
    {
        public Student() : base() { }
        public Student(int id, string? userName, string? password, string? phoneNum, bool isAdmin, string? fullName, DateOnly enrolementDate, float gradeAvg, List<Exam> allExamsTaken):
            base( id, userName, password, phoneNum, isAdmin, fullName)
        {
            EnrolementDate = enrolementDate;
            GradeAvg = gradeAvg;
            AllExamsTaken = allExamsTaken;
        }
        [NotMapped]//dateonly didnt work for db
        public DateOnly EnrolementDate { get; set; }
        public float GradeAvg { get; set; }
        public List<Exam> AllExamsTaken { get; set;}

    }
}
