using Exams_Application.Interfaces;
using Exams_Application.Models;

namespace Exams_Application.Repositories
{
    public class ExamRepo : IExamRepo
    {
        //create controller with authorizations
        public ExamRepo() { }
        public Exam? GetExamById(int id) { return new Exam(); }
        public List<Question> GetExamQuestions() { return new List<Question>(); }
        public List<Answer> GetExamAnswers() { return new List<Answer>(); }
        //can i create 1 function that inclued all of the three following?
        public int GetNumberOfQuestionsInExam(int examId) { return 0; }
        public int GetNumberOfQuestionsDone(int examId) { return 0; }
        public int GetNumberOfQuestionsRemained(int examId) { return 0; }
        public DateTime GetStartDate(int examId) { return DateTime.MinValue; }
        public DateTime GetEndDate(int examId) { return DateTime.MinValue; }
        public DateTime GetTimeRemained(int examId) { return DateTime.MinValue; }
        public ExamStudent SubmitExamStudenToDb(int examId) { throw new NotImplementedException(); }
    }
}
