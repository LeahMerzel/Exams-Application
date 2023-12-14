namespace Exams_Application.Models
{
    public class Course: BaseEntity
    {
        public List<Teacher>? CourseTeachers { get; set; }
        public List<Student>? CourseStudents { get; set; }
        public List<Exam>? CourseExams { get; set; }

    }
}
