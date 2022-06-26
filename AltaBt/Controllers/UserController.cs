using AltaBt.iRepo;
using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUser _istudent;
        public UserController(IUser istudent)
        {
            _istudent = istudent;
        }
        [HttpGet]
        public ActionResult get()
        {
            var st = _istudent.getAll();
            if (st == null)
            {
                return NotFound();
            }
            return Ok(st);
        }
        [HttpGet("{Username}")]
        public ActionResult getStudent(string Username)
        {
            var st = _istudent.get(Username);
            if (st == null)
            {
                return NotFound();
            }
            return Ok(st);
        }
        [HttpPost]
        public ActionResult postStudent(User st)
        {
            _istudent.create(st);
            return Ok();
        }
        
        [HttpDelete("{Username}")]
        public ActionResult Delete(string Username)
        {
            _istudent.delete(Username);
            return NoContent();
        }
        [HttpPut]
        public ActionResult Update(User Std)
        {
            _istudent.update(Std);
            return NoContent();
        }
    }
}
