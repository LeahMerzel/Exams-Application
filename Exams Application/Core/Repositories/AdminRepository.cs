using Exams_Application.Data.Models;
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
