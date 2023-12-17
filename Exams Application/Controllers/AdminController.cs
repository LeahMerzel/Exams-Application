using Exams_Application.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AdminRepository _adminRepository;
        public AdminController(AdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        //use async Task<IActionResult>

        //this is a controller to control all admins of app, if makes sense
        //and admins have access to userAccounts controller and all other relavant controllers

       

    }
}


