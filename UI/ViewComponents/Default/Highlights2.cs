using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class Highlights2:ViewComponent
    {
        Highlights2Manager highlights2Manager = new Highlights2Manager(new EfHightlights2Repository());
        public IViewComponentResult Invoke()
        {
            return View(highlights2Manager.GetAll());
        }
    }
}
