using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ArchitectWeb.ViewComponents.Dashboard
{
    public class StatisticDashboard2 : ViewComponent
    {
        Context c = new Context();
        public ViewViewComponentResult Invoke() 
        {
            ViewBag.v1 = c.Messages.Count();
            ViewBag.v2 = c.Projects.Count();
            ViewBag.v3 = c.Services.Count();
            return View(); 
        }
    }
}
