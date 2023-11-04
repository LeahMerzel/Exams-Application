using Exams_Application.Models;

namespace Exams_Application.Repositories
{
    public interface IStudentCrudRepo
    {
        Exam? LoginToExam(int examId);
        string SubmitExam(Exam exam);
        List<Exam>? GetAllExamsTaken(int studentId);

    }
}