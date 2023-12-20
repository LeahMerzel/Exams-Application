using Microsoft.AspNetCore.Mvc;

public interface IGenericController<T>
{
    Task<IActionResult> Create([FromBody] T entity);
    Task<IActionResult> Delete(int id);
    Task<ActionResult<IEnumerable<T>>> GetAll();
    Task<ActionResult<T>> GetById(int id);
    Task<Guid> GetEntityId(T entity);
    Task<IActionResult> Update(Guid id, [FromBody] T entity);
}