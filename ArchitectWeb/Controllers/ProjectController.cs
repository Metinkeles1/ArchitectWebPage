using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Project List";
            ViewBag.v2 = "Projects";
            ViewBag.v3 = "Project List";
            var values = projectManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProject()
        {
            ViewBag.v1 = "Project List";
            ViewBag.v2 = "Projects";
            ViewBag.v3 = "Add Project";
            return View();
        }
        [HttpPost]
        public IActionResult AddProject(Project p)
        {           
            projectManager.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
