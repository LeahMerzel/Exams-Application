using Exams_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class UserAccountRepository: GenericRepository<User>
    {
        public UserAccountRepository(DbContext dbContext): base(dbContext) 
        {
        }

    }
}
