using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class StudentExam: BaseEntity
    {
        public int Grade { get; set; }
        //dp i need this? public List<Question>? QuestionsAnswered { get; set; }
        public List<Question>? QuestionsFailed { get; set; }
        [ForeignKey("Student")]
        public Guid StudentId { get; set; }
        [ForeignKey("Exam")]
        public int ExamId { get; set; }

        //figures dont need a ctor to sart MistakesInExam cus not always are there mistakes
    }
}
