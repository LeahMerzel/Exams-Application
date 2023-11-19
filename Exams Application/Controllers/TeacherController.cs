using Exams_Application.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly TeacherRepo _teacherRepository;
        public TeacherController(TeacherRepo teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        // GET: api/<TeacherCrudController>
        [HttpGet("GetAllExams-{id}")]
        public List<Exam>? GetAllExams(int teacherId)
        {
            return _teacherRepository.GetAllExams(teacherId);
        }

        // GET api/<TeacherCrudController>/5
        [HttpGet("GetAllQuestionsOfExam-{id}")]
        public List<Question>? GetAllQuestionsOfExam(int examId)
        {
            return _teacherRepository.GetAllQuestionsOfExam(examId);
        }

        // POST api/<TeacherCrudController>/5
        [Route("[action]")]
        [HttpPost()]
        public Exam? CreateExam(Exam exam)
        {
            return _teacherRepository.CreateExam(exam);
        }

        // POST api/<TeacherCrudController>
        [Route("[action]")]
        [HttpPost]
        public Question? CreateQuestion(Question question)
        {
            return _teacherRepository.CreateQuestion(question);
        }

        // PUT api/<TeacherCrudController>/5
        [Route("[action]")]
        [HttpPut]
        public Exam? UpdateExam(Exam exam)
        {
            return _teacherRepository.UpdateExam(exam);
        }

        // PUT api/<TeacherCrudController>/5
        [Route("[action]")]
        [HttpPut]
        public Question UpdateQuestion(Question questionToUptade)
        {
            return _teacherRepository.UpdateQuestion(questionToUptade);
        }

        // DELETE api/<TeacherCrudController>/5
        [HttpDelete("DeleteExam-{id}")]
        public bool DeleteExam(int examId)
        {
            return _teacherRepository.DeleteExam(examId);
        }

        // DELETE api/<TeacherCrudController>/5
        [HttpDelete("DeleteQuestion-{id}")]
        public bool DeleteQuestion(int questionId)
        {
            return _teacherRepository.DeleteQuestion(questionId);
        }

    }
}
