using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Teacher: User
    {
        public Teacher() : base() { }

        public Teacher(int id, string? userName, string? password, string? phoneNum, bool isAdmin, string? fullName, DateOnly hireDate, List<Student> teachersStudents, List<Exam> allTeachersExams, List<Exam> submitedExams)
            : base(id, userName, password, phoneNum, isAdmin, fullName)

        {
            HireDate = hireDate;
            TeachersStudents = teachersStudents;
            AllTeachersExams = allTeachersExams;
            SubmitedExams = submitedExams;
        }

        [NotMapped]
        public DateOnly HireDate { get; set; }
        public List<Student> TeachersStudents { get; set; }
        public List<Exam> AllTeachersExams { get; set; }
        public List<Exam> SubmitedExams { get; set; }
    }
}
