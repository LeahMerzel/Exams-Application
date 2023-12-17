using Exams_Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class GenericController<T> : ControllerBase, IGenericController<T>
{
    private readonly IGenericRepository<T> repository;

    public GenericController(IGenericRepository<T> repository)
    {
        this.repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<T>> GetAll()
    {
        var entities = repository.GetAll();
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public ActionResult<T> GetById(int id)
    {
        var entity = repository.GetById(id);

        if (entity == null)
        {
            return NotFound();
        }

        return Ok(entity);
    }

    [HttpPost]
    public IActionResult Create([FromBody] T entity)
    {
        if (entity == null)
        {
            return BadRequest();
        }

        repository.Add(entity);
        return CreatedAtAction(nameof(GetById), new { id = GetEntityId(entity) }, entity);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, [FromBody] T entity)
    {
        Guid entityId = GetEntityId(entity);

        if (id != entityId)
        {
            return BadRequest();
        }

        repository.Update(entity);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var entity = repository.GetById(id);

        if (entity == null)
        {
            return NotFound();
        }

        repository.Delete(entity);
        return NoContent();
    }
    //maybe want to change following - there are lots of options as to how to implement method
    //also need to understand it better
    public Guid GetEntityId(T entity)
    {
        var idProperty = entity?.GetType().GetProperty("Id");
        var idValue = idProperty?.GetValue(entity);

        if (idValue is Guid guidValue)
        {
            return guidValue;
        }

        throw new InvalidOperationException("Invalid or missing 'Id' property value.");
    }

}
