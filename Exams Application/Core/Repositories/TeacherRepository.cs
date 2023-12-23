using Exams_Application.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class TeacherRepository: GenericRepository<Teacher>
    {
        public TeacherRepository(DbContext dbContext) : base(dbContext)
        {
        }

        
    }
}
