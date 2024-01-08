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
        private readonly ExamsRepository? examRepository;
        public ExamsController(ExamsRepository examsRepository) :base(examsRepository) 
        {
        }

    }
}


