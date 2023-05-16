using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
