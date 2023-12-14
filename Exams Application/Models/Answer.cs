using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Answer: BaseEntity
    {
        public int AnswerNumber { get; set; }
        public string? AnswerDetailed { get; set; }
        public bool IsCorrect { get; set; }
        [ForeignKey("Question")]
        public Guid QuestionId { get; set; }
    }
}