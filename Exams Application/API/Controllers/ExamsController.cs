using Exams_Application.Core.Repositories;
using Exams_Application.Data.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : GenericController<Exam>
    {
        private readonly ExamsRepository examRepository;
        public ExamsController(ExamsRepository examsRepository) :base(examsRepository) 
        {
        }

        [HttpPost("{id}/start-timer")]
        public async Task<IActionResult> StartExamTimer(Guid id, [FromBody] int durationInMinutes)
        {
            var success = await examRepository.StartExamTimer(id, durationInMinutes);

            if (success)
            {
                return Ok();
            }

            return NotFound();
        }

    }
}


