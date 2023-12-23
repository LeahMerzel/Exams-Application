using Exams_Application.Core.Repositories;
using Exams_Application.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : GenericController<Exam>
    {
        public ExamsController(ExamsRepository examsRepository) :base(examsRepository) 
        {
        }
    }
}


