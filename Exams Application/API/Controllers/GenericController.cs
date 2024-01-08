using Exams_Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
    public async Task<ActionResult<IEnumerable<T>>> GetAll()
    {
        var entities = await repository.GetAll();
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public ActionResult<T> GetById(Guid id)
    {
        var entity = repository.GetById(id);

        if (entity == null)
        {
            return NotFound();
        }

        return Ok(entity);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] T entity)
    {
        if (entity == null)
        {
            return BadRequest();
        }

        await repository.Add(entity);
        return CreatedAtAction(nameof(GetById), new { id = GetEntityId(entity) }, entity);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] T entity)
    {
        Guid entityId = GetEntityId(entity);

        if (id != entityId)
        {
            return BadRequest();
        }

        await repository.Update(entity);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var entity = repository.GetById(id);

        if (entity == null)
        {
            return NotFound();
        }

        await repository.Delete(entity);
        return NoContent();
    }
    //maybe want to change following - there are lots of options as to how to implement method
    //also need to understand it better
    [HttpGet("GetEntityId")]
    public Guid GetEntityId(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        var idProperty = entity.GetType().GetProperty("Id");

        if (idProperty == null)
        {
            throw new InvalidOperationException($"Type {entity.GetType().Name} does not have a property named 'Id'.");
        }

        var idValue = idProperty.GetValue(entity);

        if (idValue is Guid guidValue)
        {
            return guidValue;
        }

        throw new InvalidOperationException($"Invalid or missing 'Id' property value. Actual type: {idValue?.GetType().Name}");
    }

}
