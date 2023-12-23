using Exams_Application.Data.DB;
using Exams_Application.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class StudentRepository: GenericRepository<Student>
    {
        public StudentRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }

    }
}
