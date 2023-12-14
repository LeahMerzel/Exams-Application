using Exams_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class CourseRepository : GenericRepository<Course>
    {
        public CourseRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
