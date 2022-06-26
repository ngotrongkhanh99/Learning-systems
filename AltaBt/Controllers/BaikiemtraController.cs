using AltaBt.iRepo;
using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaikiemtraController : ControllerBase
    {
        public readonly IBaiKiemtra _itest;
        public BaikiemtraController(IBaiKiemtra itest)
        {
            _itest = itest;
        }
        [HttpGet]
        public ActionResult get()
        {
            var t = _itest.getAll();
            if (t == null)
            {
                return NotFound();
            }
            return Ok(t);
        }
        [HttpGet("{IdKiemtra}")]
        public ActionResult get(int IdKiemtra)
        {
            var t = _itest.get(IdKiemtra);
            if (t == null)
            {
                return NotFound();
            }
            return Ok(t);
        }
        [HttpPost]
        public ActionResult postTest(Baikiemtra test)
        {
            _itest.create(test);
            return Ok();
        }
        [HttpDelete("{IdKiemtra}")]
        public ActionResult Delete(int IdKiemtra)
        {
            _itest.delete(IdKiemtra);
            return NoContent();
        }
        [HttpPut]
        public ActionResult Update(Baikiemtra test)
        {
            _itest.update(test);
            return NoContent();
        }
    }
}
