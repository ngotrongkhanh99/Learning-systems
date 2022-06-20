using AltaBt.iRepo;
using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        public readonly ITeacher _iteacher;
        public TeacherController(ITeacher iteacher)
        {
            _iteacher = iteacher;
        }
        [HttpGet]
        public ActionResult get()
        {
            var t = _iteacher.getAll();
            if (t == null)
            {
                return NotFound();
            }
            return Ok(t);
        }
        [HttpGet("{Username}")]
        public ActionResult getTeacher(string Username)
        {
            var t = _iteacher.get(Username);
            if (t == null)
            {
                return NotFound();
            }
            return Ok(t);
        }
        [HttpPost]
        public ActionResult postTeacher(Teacher t)
        {
            _iteacher.create(t);
            return Ok();
        }
        [HttpDelete("{Username}")]
        public ActionResult Delete(string Username)
        {
            _iteacher.delete(Username);
            return NoContent();
        }
        [HttpPut]
        public ActionResult Update(Teacher t)
        {
            _iteacher.update(t);
            return NoContent();
        }
    }
}
