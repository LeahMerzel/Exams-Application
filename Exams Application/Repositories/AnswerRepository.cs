using Exams_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class AnswerRepository : GenericRepository<Answer>
    {
        public AnswerRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
