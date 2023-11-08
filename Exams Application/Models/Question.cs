using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Models
{
    public class Question
    {
       
        [Key]
        public int QuestionNumber { get; set; }
        public string QuestionName { get; set; }
        public string QuestionDescription { get; set; }
        public bool IsImage { get; set; }
        public List<Answer> Answers { get; set; }
        public bool IsOrderAnswersRandom { get; set; }
        public int QuestionScoring { get; set; }
    }
}
