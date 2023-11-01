using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Models
{
    public class Question
    {
        public Question()
        {
            
        }
        public Question(int questionNumber, string questionName, string questionDescription, bool isImage, List<Answer> answers, bool isOrderAnswersRandom, int questionScoring)
        {
            QuestionNumber = questionNumber;
            QuestionName = questionName;
            QuestionDescription = questionDescription;
            IsImage = isImage;
            Answers = answers;
            IsOrderAnswersRandom = isOrderAnswersRandom;
            QuestionScoring = questionScoring;
        }
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
