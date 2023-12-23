﻿using Exams_Application.Data.DB;
using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Core.Repositories
{
    public class UserAccountRepository : GenericRepository<User>
    {
        public UserAccountRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }

    }
}
