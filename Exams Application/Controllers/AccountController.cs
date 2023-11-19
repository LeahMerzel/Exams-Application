using Exams_Application.Interfaces;
using Exams_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers


    //maybe can do Unity of work instead of accout repo becuase 
    //all users use these functions ????

{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepo _accountRepository;
        public AccountController(IAccountRepo accountRepository)
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
