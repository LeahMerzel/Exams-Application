using Exams_Application.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Core.Repositories
{
    public class CourseRepository : GenericRepository<Course>
    {
        public CourseRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
