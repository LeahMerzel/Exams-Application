using Exams_Application.Data.DB;
using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Core.Repositories
{
    public class CourseRepository : GenericRepository<Course>
    {
        public CourseRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }

    }
}
