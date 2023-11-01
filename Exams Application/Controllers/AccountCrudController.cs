using Exams_Application.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountCrudController : ControllerBase
    {
        private readonly IAccountCrudRepo _accountRepository;
        public AccountCrudController(IAccountCrudRepo accountRepository)
        {
            _accountRepository = accountRepository;
        }

        //GET: api/<AccountCrud>
        [HttpGet]
        public User? Login(string userName, string password)
        {
            return _accountRepository.Login(userName, password);    
        }

        // POST api/<AccountCrud>
        [HttpPost]
        public User CreateAccount([FromBody] User user)
        {
            return _accountRepository.CreateAccount(user);
        }

        // PUT api/<AccountCrud>/5
        [HttpPut("{id}")]
        //  is PUT right for logout? if i use cookies then also login should?    
        public bool Logout([FromBody] int userId)
        {
            return _accountRepository.Logout(userId);
        }

        [HttpPut]
        //   when to use [FromBody]? 
        public bool UpdateAccountDetails([FromBody] User userUpdated)
        {
            return _accountRepository.UpdateAccountDetails(userUpdated);
        }

        // DELETE api/<AccountCrud>/5
        [HttpDelete("{id}")]
        public bool DeleteAccount(int userId)
        {
            return _accountRepository.DeleteAccount(userId);
        }
    }
}
