using AltaBt.iRepo;
using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public readonly ITest _itest;
        public TestController(ITest itest)
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
        [HttpGet("{TestId}")]
        public ActionResult getTest(int TestId)
        {
            var t = _itest.get(TestId);
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
        [HttpDelete("{TestId}")]
        public ActionResult Delete(int TestId)
        {
            _itest.delete(TestId);
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
