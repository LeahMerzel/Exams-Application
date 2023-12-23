using Exams_Application.Data.DB;
using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Core.Repositories
{
    public class AnswerRepository : GenericRepository<Answer>
    {
        public AnswerRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }

        public string GetCorrectAnswer(Question question)
        {
            var answerList = question.Answers != null ? question.Answers.ToList() : null;
            if (answerList != null)
            {
                var correctAnswer = answerList.Find(a => a.IsCorrect = true);
                if (correctAnswer != null)
                    return correctAnswer.AnswerDetailed != null ? correctAnswer.AnswerDetailed : "couldn't find the correct answer.";
            }
            return "couldn't find the correct answer.";
        }

    }
}
