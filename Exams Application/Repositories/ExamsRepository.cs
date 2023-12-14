using Exams_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class ExamsRepository : GenericRepository<Exam>
    {
        public ExamsRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
