using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UI.ViewComponents.Default
{
    public class Statistics:ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2=c.Guides.Count();
            return View();
        }

    }
}
