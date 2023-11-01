using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public int QuestionNumber { get; set; }
        public string? AnswerDetailed { get; set; }
        public int QuestionId { get; set; }
        public bool IsCorrect { get; set; }

    }
}