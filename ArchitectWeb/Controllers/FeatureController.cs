using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDAl());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Features Edit";
            ViewBag.v2 = "Feature";
            ViewBag.v3 = "Edit Features";
            var values = featureManager.TGetByID(1);
            return View(values);
        }
       
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index");
        }
    }
}
