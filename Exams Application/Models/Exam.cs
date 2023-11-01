using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Models
{
    public class Exam
    {
        public Exam()
        {
        }
        public Exam(int examId, string examName, DateTime examDateTime, int examDuration, DateTime examBegganAt, bool isOrderQuestionsRandom, int teacherId, string examDescription, List<Question> examQuestions, int studentId, int grade)
        {
            ExamId = examId;
            ExamName = examName;
            ExamDateTime = examDateTime;
            ExamDuration = examDuration;
            ExamBegganAt = examBegganAt;
            IsOrderQuestionsRandom = isOrderQuestionsRandom;
            TeacherId = teacherId;
            ExamDescription = examDescription;
            ExamQuestions = examQuestions;
            StudentId = studentId;
            Grade = grade;
        }

        [Key]
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public DateTime ExamDateTime { get; set; }
        public int ExamDuration { get; set; }
        public DateTime ExamBegganAt { get; set; }
        public bool IsOrderQuestionsRandom { get; set; }
        public int TeacherId { get; }
        public string ExamDescription { get; set; }
        public List<Question> ExamQuestions { get; set; } 
        public int StudentId { get; set; }
        public int Grade { get; set; }

    }
}
