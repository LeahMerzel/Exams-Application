using Exams_Application.Interfaces;
using Exams_Application.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepo _adminRepository;
        public AdminController(IAdminRepo adminRepository)
        {
            _adminRepository = adminRepository;
        }

        // GET api/<AdminCrudController>/5
        [HttpGet("{id}")]
        public User? GetAccountById(int id)
        {
            return _adminRepository.GetAccountById(id);
        }

        // GET api/<AdminCrudController>/5
        [HttpGet]
        public List<User> GetAllAccounts()
        {
            return _adminRepository.GetAllAcounts();
        }

        // POST api/<AdminCrudController>
        [HttpPost]
        public User CreateAccount([FromBody] User user)
        {
            return _adminRepository.CreateAccount(user);
        }

        // DELETE api/<AdminCrudController>/5
        [HttpDelete("{id}")]
        public bool DeleteAccount(int userId)
        {
            return _adminRepository.DeleteAccount(userId);
        }
    }
}
