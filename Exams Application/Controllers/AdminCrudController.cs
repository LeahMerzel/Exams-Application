using Exams_Application.Interfaces;
using Exams_Application.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminCrudController : ControllerBase
    {
        private readonly IAdminCrudRepo _adminRepository;
        public AdminCrudController(IAdminCrudRepo adminRepository)
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
