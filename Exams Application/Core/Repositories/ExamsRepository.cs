using Exams_Application.Data.DB;
using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Core.Repositories
{
    public class ExamsRepository : GenericRepository<Exam>
    {
        public ExamsRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> StartExamTimer(Guid entityId, int durationInMinutes)
        {
            var exam = await dbContext.Set<Exam>().FindAsync(entityId);

            if (exam == null)
            {
                return false; // Exam not found
            }

            // Start the exam timer with the specified duration
            exam.StartExamTimer(durationInMinutes);

            // Save changes to the database
            await dbContext.SaveChangesAsync();

            return true; // Success
        }

    }
}
