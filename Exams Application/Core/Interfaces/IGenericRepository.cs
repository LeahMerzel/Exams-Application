namespace Exams_Application.Interfaces
{
    public interface IGenericRepository<T>
    {
        T? GetById(Guid? id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<T> Find(Func<object, object> value);
    }
}
