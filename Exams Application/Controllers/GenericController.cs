using Exams_Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class GenericController<T> : ControllerBase
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
    public IActionResult Update(int id, [FromBody] T entity)
    {
        if (id != GetEntityId(entity))
        {
            return BadRequest();
        }

        repository.Update(entity);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        repository.Delete(id);
        return NoContent();
    }

    private int GetEntityId(T entity)
    {
        // Implement logic to get the ID from the generic entity
        // This method assumes there's an 'Id' property; adjust as needed
        var idProperty = entity.GetType().GetProperty("Id");
        return (int)idProperty.GetValue(entity);
    }
}
