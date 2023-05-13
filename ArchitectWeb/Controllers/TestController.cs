using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
