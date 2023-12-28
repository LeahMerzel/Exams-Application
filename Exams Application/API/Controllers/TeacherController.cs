using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : GenericController<Teacher>
    {
        private readonly TeacherRepository teacherRepository;
        public TeacherController(TeacherRepository teacherRepository) :base(teacherRepository) 
        {
        }
    }
}


