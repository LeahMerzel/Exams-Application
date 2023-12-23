using Microsoft.AspNetCore.Mvc;

public interface IGenericController<T>
{
    Task<IActionResult> Create([FromBody] T entity);
    Task<IActionResult> Delete(Guid id);
    Task<ActionResult<IEnumerable<T>>> GetAll();
    Task<ActionResult<T>> GetById(Guid id);
    Guid GetEntityId(T entity);
    Task<IActionResult> Update(Guid id, [FromBody] T entity);
}