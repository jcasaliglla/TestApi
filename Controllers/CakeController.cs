using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    public class CakeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
