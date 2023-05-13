using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "Dashboard";
            ViewBag.v3 = "Dashboard Page";
            return View();
        }
    }
}
