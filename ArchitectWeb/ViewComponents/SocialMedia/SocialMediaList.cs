using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.ViewComponents.SocialMedia
{
    public class SocialMediaList : ViewComponent
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialmediaDal());
        public IViewComponentResult Invoke()
        {
            var result = socialMediaManager.TGetList();
            return View(result);
        }
    }
}
