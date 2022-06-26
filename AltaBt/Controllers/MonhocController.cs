using AltaBt.iRepo;
using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonhocController : ControllerBase
    {
        public readonly IMonhoc _isubject;
        public MonhocController(IMonhoc isubject)
        {
            _isubject = isubject;
        }
        [HttpGet]
        public ActionResult get()
        {
            var sj = _isubject.getAll();
            if (sj == null)
            {
                return NotFound();
            }
            return Ok(sj);
        }
        [HttpGet("{IdMonhoc}")]
        public ActionResult getSubject(int IdMonhoc)
        {
            var sj = _isubject.get(IdMonhoc);
            if (sj == null)
            {
                return NotFound();
            }
            return Ok(sj);
        }
        [HttpPost]
        public ActionResult postSubject(Monhoc Sj)
        {
            _isubject.create(Sj);
            return Ok();
        }

        [HttpDelete("{IdMonhoc}")]
        public ActionResult Delete(int IdMonhoc)
        {
            _isubject.delete(IdMonhoc);
            return NoContent();
        }
        [HttpPut]
        public ActionResult Update(Monhoc Sj)
        {
            _isubject.update(Sj);
            return NoContent();
        }
    }
}

