using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class SubAbout:ViewComponent
    {
        SubAboutManager _manager = new SubAboutManager(new EfSubAboutRepository());
        public IViewComponentResult Invoke()
        {
            return View(_manager.GetAll());
        }
    }
}
