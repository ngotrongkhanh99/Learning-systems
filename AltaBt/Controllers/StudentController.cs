using AltaBt.iRepo;
using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudent _istudent;
        public StudentController(IStudent istudent)
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
        public ActionResult postStudent(Student st)
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
        public ActionResult Update(Student Std)
        {
            _istudent.update(Std);
            return NoContent();
        }
    }
}
