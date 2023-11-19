using Exams_Application.Interfaces;
using Exams_Application.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _studentReposetory;
        public StudentController(IStudentRepo studentReposetory)
        {
            _studentReposetory = studentReposetory;//like this in re[po with dbcontext  לא חובה
        }

        // GET: api/<StudentCrudController>
        [HttpGet("GetAllExamsTaken-{id}")]
        public List<Exam>? GetAllExamsTaken(int studentId)//צריך ולידציות במקום ברפוזטוריז ולהחליף לiactionresult
            //can get validated from repo and validate here
        {
            return _studentReposetory.GetAllExamsTaken(studentId);
        }

        // GET api/<StudentCrudController>/5
        [HttpGet("LoginToExam-{id}")]
        public Exam? LoginToExam(int examId)
        {
            return _studentReposetory.LoginToExam(examId);
        }

/*        // POST api/<StudentCrudController>
        [HttpPost]
        public string SubmitExam([FromBody] Exam exam)
        {
            return _studentReposetory.SubmitExam(exam);
        }
*/
    }
}
