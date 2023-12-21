using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Timers;

namespace Exams_Application.Models
{
    public class Exam: BaseEntity
    {
        [ForeignKey("Teacher")]
        public Guid TeacherOwnsExamId { get; }
        public string? ExamDescription { get; set; }
        public DateTime ExamDateTime { get; set; }

        //public System.Timers.Timer? ExamTimer { get; set; } - how to use this?
        //and dont i need a ctor for this class so that when a iser starts taking an exam the times will start?
        //so decide if need the following two props:
        //public DateTime ExamBegganAt { get; set; }
        //public DateTime ExamDurationTimer { get; set; }
        public bool WasExamLoggedInToByStudent { get; set; }
        public bool IsOrderQuestionsRandom { get; set; }
        public List<Question>? ExamQuestions { get; set; }
        public int ExamGrade { get; set; }
        public float ExamGradeAvg { get; set; }
        public Exam()
        {
            ExamQuestions = new List<Question>(); 
            ExamGrade = 0;
        }

    }
}
