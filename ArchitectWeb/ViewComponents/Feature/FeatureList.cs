using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDAl());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();            
            return View(values);
        }
    }
}
