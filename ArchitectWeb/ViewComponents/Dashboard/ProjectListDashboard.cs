using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.ViewComponents.Dashboard
{
    public class ProjectListDashboard : ViewComponent
    {
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        public IViewComponentResult Invoke()
        {
            var values = projectManager.TGetList();
            return View(values);
        }
    }
}
