namespace Exams_Application.Models
{
    public class Course: BaseEntity
    {
        public List<Teacher>? CourseTeachers { get; set; } = new List<Teacher>();
        public List<Student>? CourseStudents { get; set; } = new List<Student>();
        public List<Exam>? CourseExams { get; set; } = new List<Exam>();

    }
}
