using Exams_Application.Models;

namespace Exams_Application.Repositories
{
    public interface IStudentRepo
    {
        List<Exam>? GetAllExamsToDo(int studentsTeacherId);
        Exam? GetExamToDoById(int ExamId);
        Exam? LoginToExam(int examId);
        List<Exam>? GetAllExamsTaken(int studentId);

    }
}