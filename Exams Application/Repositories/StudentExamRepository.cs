using Exams_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class StudentExamRepository : GenericRepository<StudentExam>
    {
        public StudentExamRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public async Task<StudentExam> SubmitStudentExamToDb(StudentExam studentExam)
        {
            var student = await dbContext.Set<Student>().SingleOrDefaultAsync(s => s.Id == studentExam.StudentId);

            if (student != null)
            {
                //...
            }

            // Perform other operations and return the grade or result
            return studentExam;
        }
        public List<Question> ReturnQuestionsFailedInExam(Guid StudentExamId) { throw new NotImplementedException();}
       
        //should the following 2 or 3 be part of Client side code?
        public int GetNumberOfQuestionsDone(int examId) { return 0; }
        public int GetNumberOfQuestionsRemained(int examId) { return 0; }

        //start Timer when student gets Exam
    }
}
