using Exams_Application.Core.Repositories;
using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccountController : GenericController<User>
    {
        private readonly UserAccountRepository userAccountRepository;
        public UserAccountController(UserAccountRepository userAccountRepository) :base(userAccountRepository) 
        {
        }
    }
}


