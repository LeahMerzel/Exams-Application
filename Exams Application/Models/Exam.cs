using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        public int TeacherOwnsExamId { get; }
        public string ExamName { get; set; }
        public string ExamDescription { get; set; }
        public DateTime ExamDateTime { get; set; }
        public DateTime ExamBegganAt { get; set; }
        public DateTime ExamDurationTimer { get; set; }
        public bool IsOrderQuestionsRandom { get; set; }
        public List<Question> ExamQuestions { get; set; }
        public ICollection<Student> StudentsToDoExam { get; set; } 
    }
}
