using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class Question: BaseEntity
    {
        public int QuestionNumber { get; set; }
        public string? QuestionDescription { get; set; }
        public bool IsImage { get; set; }
        public List<Answer>? Answers { get; set; } = new List<Answer>();
        public bool IsOrderAnswersRandom { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public int QuestionScoring { get; set; }
        [ForeignKey("Exam")]
        public Guid ExamId { get; set; }
    }
}
