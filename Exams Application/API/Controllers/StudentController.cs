using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : GenericController<Student>
    {
        private readonly StudentRepository? studentRepository;
        public StudentController(StudentRepository studentRepository) :base(studentRepository) 
        {
        }
    }
}


