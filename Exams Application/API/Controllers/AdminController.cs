using Exams_Application.Data.Models;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : GenericController<Admin>
    {
        public AdminController(AdminRepository adminRepository) :base(adminRepository) 
        {
        }
        //use async Task<IActionResult>

        //this is a controller to control all admins of app, if makes sense
        //and admins have access to userAccounts controller and all other relavant controllers

       

    }
}


