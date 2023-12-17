using Microsoft.AspNetCore.Mvc;

public interface IGenericController<T>
{
    IActionResult Create([FromBody] T entity);
    IActionResult Delete(int id);
    ActionResult<IEnumerable<T>> GetAll();
    ActionResult<T> GetById(int id);
    Guid GetEntityId(T entity);
    IActionResult Update(Guid id, [FromBody] T entity);
}