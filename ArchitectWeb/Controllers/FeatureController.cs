using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
