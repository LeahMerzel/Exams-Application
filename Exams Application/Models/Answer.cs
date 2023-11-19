using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Models
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerNumber { get; set; }
        public string? AnswerDetailed { get; set; }
        public bool IsCorrect { get; set; }

    }
}