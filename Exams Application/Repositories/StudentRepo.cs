using Exams_Application.Interfaces;
using Exams_Application.Models;

namespace Exams_Application.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        private readonly ExamsDbContext db;
        public StudentRepo(ExamsDbContext dbContext)
        {
            db = dbContext;
        }
        public List<Exam>? GetAllExamsToDo(int studentsTeacherId)
        {
            var examsListToDo = db.Exams.Where(e => e.TeacherId == studentsTeacherId).ToList();
            if (examsListToDo.Any())
                return examsListToDo;
            return null;
        }
        public Exam? GetExamToDoById(int ExamId)
        {
            var exam = db.Exams.SingleOrDefault(e => e.ExamId == ExamId);
            if (exam == null)
                return exam;
            return null;
        }

        public Exam? LoginToExam(int examId)
        {
            var exam = db.Exams.SingleOrDefault(e => e.ExamId == examId);
            if (exam != null)
            {
                return exam;
            }
            return null;
        }
        public List<Exam>? GetAllExamsTaken(int studentId)
        {
            if (studentId != 0)
            {
                var student = db.Students.SingleOrDefault(s => s.Id == studentId);
                if (student != null)
                {
                    if (student.AllExamsTaken != null)
                    {
                        return student.AllExamsTaken.ToList();
                    }
                    return null;
                }
            }
            return null;
        }
        //do it here or in Exan repo?
        //can i create 1 function that incued all of the three following?
        //-----> if i do here then need to add to interface
        public int GetNumberOfQuestionsInExam(int examId) { return 0; }
        public int GetNumberOfQuestionsDone(int examId) { return 0; }
        public int GetNumberOfQuestionsRemained(int examId) { return 0; }


    }
}
