using Exams_Application.Data.DB;
using Exams_Application.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class AdminRepository : GenericRepository<Admin>
    {
        public AdminRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }

    }
}
