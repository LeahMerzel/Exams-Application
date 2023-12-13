using Exams_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class AdminRepository : GenericRepository<Admin>
    {
        public AdminRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
