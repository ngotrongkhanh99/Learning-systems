using AltaBt.iRepo;
using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PowerController : ControllerBase
    {
        public readonly IPower _ipower;
        public PowerController(IPower ipower)
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
        [HttpGet("{id}")]
        public ActionResult getPower(int id)
        {
            var poweri = _ipower.get(id);
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
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _ipower.delete(id);
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
