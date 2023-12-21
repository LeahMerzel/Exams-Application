using Exams_Application.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
