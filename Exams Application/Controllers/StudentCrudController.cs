using Exams_Application.Interfaces;
using Exams_Application.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCrudController : ControllerBase
    {
        private readonly IStudentCrudRepo _studentReposetory;
        public StudentCrudController(IStudentCrudRepo studentReposetory)
        {
            _studentReposetory = studentReposetory;
        }

        // GET: api/<StudentCrudController>
        [HttpGet("GetAllExamsTaken-{id}")]
        public List<Exam>? GetAllExamsTaken(int studentId)
        {
            return _studentReposetory.GetAllExamsTaken(studentId);
        }

        // GET api/<StudentCrudController>/5
        [HttpGet("LoginToExam-{id}")]
        public Exam? LoginToExam(int examId)
        {
            return _studentReposetory.LoginToExam(examId);
        }

        // POST api/<StudentCrudController>
        [HttpPost]
        public string SubmitExam([FromBody] Exam exam)
        {
            return _studentReposetory.SubmitExam(exam);
        }

    }
}
