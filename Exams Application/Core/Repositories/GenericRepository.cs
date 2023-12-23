using Exams_Application.Data.DB;
using Exams_Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ExamsDbContext dbContext;

        public GenericRepository(ExamsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public T? GetById(Guid? id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task Add(T entity)
        {
            dbContext.Set<T>().Add(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<T?> Find(Func<object, object> value)
        {
            var foundObj = await dbContext.Set<T>().FindAsync();
            return foundObj != null ? foundObj : null;
        }

    }
}
