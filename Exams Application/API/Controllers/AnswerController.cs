using Exams_Application.Core.Repositories;
using Exams_Application.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : GenericController<Answer>
    {
        private readonly AnswerRepository answerRepository;

        public AnswerController(AnswerRepository repository) : base(repository)
        {
            this.answerRepository = repository;
        }

        [HttpGet("correct/{questionId}")]
        public ActionResult<string> GetCorrectAnswer(Question question)
        {
            var correctAnswer = answerRepository.GetCorrectAnswer(question);

            if (question == null)
            {
                return NotFound();
            }

            return Ok(question);
        }
    }
}
