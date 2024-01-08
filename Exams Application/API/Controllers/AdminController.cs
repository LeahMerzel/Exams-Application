using Exams_Application.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Exams_Application.Repositories;
using Exams_Application.Core.Repositories;

namespace Exams_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : GenericController<Admin>
    {
        private readonly AdminRepository? adminRepository;
        public AdminController(AdminRepository adminRepository) :base(adminRepository) 
        {
        }
       

    }
}


