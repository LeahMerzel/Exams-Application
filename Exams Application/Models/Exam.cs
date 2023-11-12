using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Models
{
    public class Exam
    {
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

        //do i need this is it many to many, how to do?
        //public List<Student> StudentsToDoExam { get; } = new();

    }
}
