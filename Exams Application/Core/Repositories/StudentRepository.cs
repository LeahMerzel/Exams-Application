using Exams_Application.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class StudentRepository: GenericRepository<Student>
    {
        public StudentRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
