using Exams_Application.DB;
using Exams_Application.Interfaces;
using Exams_Application.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext dbContext;

        public GenericRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<T?> GetById(int? id)
        {
            return await dbContext.Set<T>().FindAsync(id);
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
