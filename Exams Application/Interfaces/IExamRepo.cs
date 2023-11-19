using Exams_Application.Models;

namespace Exams_Application.Interfaces
{
    public interface IExamRepo
    {
        DateTime GetEndDate(int examId);
        List<Answer> GetExamAnswers();
        Exam? GetExamById(int id);
        List<Question> GetExamQuestions();
        int GetNumberOfQuestionsDone(int examId);
        int GetNumberOfQuestionsInExam(int examId);
        int GetNumberOfQuestionsRemained(int examId);
        DateTime GetStartDate(int examId);
        DateTime GetTimeRemained(int examId);
        ExamStudent SubmitExamStudenToDb(int examId);
    }
}