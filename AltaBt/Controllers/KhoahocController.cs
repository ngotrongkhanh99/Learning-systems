using AltaBt.iRepo;
using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoahocController : ControllerBase
    {
        public readonly IKhoahoc _ikhoahoc;
        public KhoahocController(IKhoahoc ikhoahoc)
        {
            _ikhoahoc = ikhoahoc;
        }
        [HttpGet]
        public ActionResult get()
        {
            var t = _ikhoahoc.getAll();
            if (t == null)
            {
                return NotFound();
            }
            return Ok(t);
        }
        [HttpGet("{IdKhoa}")]
        public ActionResult getIdKhoa(int IdKhoa)
        {
            var t = _ikhoahoc.get(IdKhoa);
            if (t == null)
            {
                return NotFound();
            }
            return Ok(t);
        }
        [HttpPost]
        public ActionResult postKhoa(Khoahoc kh)
        {
            _ikhoahoc.create(kh);
            return Ok();
        }
        [HttpDelete("{IdKhoa}")]
        public ActionResult Delete(int IdKhoa)
        {
            _ikhoahoc.delete(IdKhoa);
            return NoContent();
        }
        [HttpPut]
        public ActionResult Update(Khoahoc kh)
        {
            _ikhoahoc.update(kh);
            return NoContent();
        }
    }
}
