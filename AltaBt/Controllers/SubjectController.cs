using AltaBt.iRepo;
using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        public readonly ISubject _isubject;
        public SubjectController(ISubject isubject)
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
        [HttpGet("{subjectID}")]
        public ActionResult getSubject(int subjectID)
        {
            var sj = _isubject.get(subjectID);
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

        [HttpDelete("{subjectID}")]
        public ActionResult Delete(int subjectID)
        {
            _isubject.delete(subjectID);
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

