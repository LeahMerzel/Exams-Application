using Exams_Application.Models;

namespace Exams_Application.Repositories
{
    public interface ITeacherRepo
    {
        Exam? CreateExam(Exam exam);
        Question? CreateQuestion(Question question);
        bool DeleteExam(int examId);
        bool DeleteQuestion(int questionId);
        List<Exam>? GetAllExams(int teacherId);
        List<Question>? GetAllQuestionsOfExam(int examId);
        Exam? UpdateExam(Exam exam);
        Question UpdateQuestion(Question questionToUptade);
    }
}