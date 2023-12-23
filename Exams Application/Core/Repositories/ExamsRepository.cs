using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Core.Repositories
{
    public class ExamsRepository : GenericRepository<Exam>
    {
        public ExamsRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
