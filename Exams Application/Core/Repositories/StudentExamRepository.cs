using Exams_Application.Data.DB;
using Exams_Application.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class StudentExamRepository : GenericRepository<StudentExam>
    {
        public StudentExamRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<StudentExam> SubmitStudentExamToDb(StudentExam studentExam)
        {
            var student = await dbContext.Set<Student>()
                .Include(s => s.StudentsTakenExams) //do i need this here if anyhow StudentsTakenExams may be null?
                .SingleOrDefaultAsync(s => s.Id == studentExam.StudentId);

            if (student != null)
            {
                student.StudentsTakenExams.Add(studentExam);
                await dbContext.SaveChangesAsync();
            }
            return studentExam;
        }
        public List<Question>? ReturnQuestionsFailedInExam(StudentExam studentExam) 
        {
            if (studentExam.QuestionsFailed != null)
            {
                var questionsFailed = studentExam.QuestionsFailed;
                return questionsFailed;
            }
            return null;
        }
       
        //should the following 2 or 3 be part of Client side code?
        public int GetNumberOfQuestionsDone(int examId) { return 0; }
        public int GetNumberOfQuestionsRemained(int examId) { return 0; }

        //start Timer when student gets Exam
    }
}
