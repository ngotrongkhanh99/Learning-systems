using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class user : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = new List<Student>
            {
                new Student { 
                    UsernameHV = "ngotrongkhanh123",
                    PasswordHV = "123",
                    NameHV = "ngotrongkhanh" ,
                    Email = "ngotrongkhanh222",
                    Phone = "123456789",
                    active = 1
                }
            };
            return Ok(users);
        }
    }
}
