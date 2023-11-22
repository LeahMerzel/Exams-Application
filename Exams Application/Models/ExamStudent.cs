using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Models
{
    public class ExamStudent
    {
        public int ExamStudentId { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}