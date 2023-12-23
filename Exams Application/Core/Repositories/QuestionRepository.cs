﻿using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Core.Repositories
{
    public class QuestionRepository : GenericRepository<Question>
    {
        public QuestionRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
