using Exams_Application.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class QuestionRepository : GenericRepository<Question>
    {
        public QuestionRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
