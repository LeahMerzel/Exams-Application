namespace Exams_Application.Data.Models
{
    public class Course : BaseEntity
    {
        public List<Teacher>? CourseTeachers { get; set; }
        public List<Student>? CourseStudents { get; set; }
        public List<Exam>? CourseExams { get; set; }
        public Course()
        {
            CourseTeachers = new List<Teacher>();
            CourseStudents = new List<Student>();
            CourseExams = new List<Exam>();
        }

    }
}
