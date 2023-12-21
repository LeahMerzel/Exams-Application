using Exams_Application.Interfaces;
using Exams_Application.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : GenericController<Admin>
    {
        public AnswerController(AdminRepository adminRepository) :base(adminRepository) 
        {
        }
        [HttpGet]

    }
}


