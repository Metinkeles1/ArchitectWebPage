using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
