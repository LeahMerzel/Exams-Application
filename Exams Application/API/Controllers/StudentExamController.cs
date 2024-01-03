using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

[Route("api/[controller]")]
[ApiController]
public class StudentExamController : GenericController<StudentExam>
{
    private readonly StudentExamRepository studentExamRepository;

    public StudentExamController(StudentExamRepository studentExamRepository) : base(studentExamRepository)
    {
        this.studentExamRepository = studentExamRepository;
    }

    [HttpPost("{id}/student-login")]
    public async Task<IActionResult> StudentLogin(Guid id)
    {
        var success = await studentExamRepository.StudentLoggedInToExam(id);

        if (success)
        {
            return Ok();
        }

        return NotFound();
    }

    [HttpPost("submit")]
    public async Task<ActionResult<StudentExam>> SubmitStudentExamToDb([FromBody] StudentExam studentExam)
    {
        var submittedExam = await studentExamRepository.SubmitStudentExamToDb(studentExam);
        return Ok(submittedExam);
    }

    [HttpGet("questionsfailed/{studentExamId}")]
    public ActionResult<List<Question>> ReturnQuestionsFailedInExam(Guid studentExamId)
    {
        var studentExam = studentExamRepository.GetById(studentExamId);
        if (studentExam == null)
        {
            return NotFound();
        }

        var questionsFailed = studentExamRepository.ReturnQuestionsFailedInExam(studentExam);
        return Ok(questionsFailed);
    }

}
