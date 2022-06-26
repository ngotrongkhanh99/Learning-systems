using AltaBt.iRepo;
using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BangdiemController : ControllerBase
    {
        public readonly IBangdiem _ipower;
        public BangdiemController(IBangdiem ipower)
        {
            _ipower = ipower;
        }
        [HttpGet]
        public ActionResult get()
        {
            var poweri = _ipower.getAll();
            if (poweri == null)
            {
                return NotFound();
            }
            return Ok(poweri);
        }
        [HttpGet("{IdBangdiem}")]
        public ActionResult getPower(int IdBangdiem)
        {
            var poweri = _ipower.get(IdBangdiem);
            if (poweri == null)
            {
                return NotFound();
            }
            return Ok(poweri);
        }
        [HttpPost]
        public ActionResult postPower(Bangdiem power)
        {
            _ipower.create(power);
            return Ok();
        }
        
        [HttpDelete("{IdBangdiem}")]
        public ActionResult Delete(int IdBangdiem)
        {
            _ipower.delete(IdBangdiem);
            return NoContent();
        }
        [HttpPut]
        public ActionResult Update(Bangdiem p)
        {
            _ipower.update(p);
            return NoContent();
        }
    }
}
