namespace Exams_Application.Interfaces
{
    public interface IGenericRepository<T>
    {
        T? GetById(int? id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Find(Func<object, object> value);
    }
}
