using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceItemManager serviceItemManager = new ServiceItemManager(new EfServiceItemDal());
        //ServiceManager serviceManager = new ServiceManager(new EfServiceDal());        
        public IViewComponentResult Invoke()
        {
            var values = serviceItemManager.GetItemWithService();            
            return View(values);
        }
    }
}
