using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{

    [ApiController]
    public class TestController : ControllerBase
    {
        [Route("api/testMethod")]
        [HttpGet]
        public ActionResult testMethod(string testParam)
        {
            return Ok(new {status = testParam});
        }
    }
}
