using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class TestiMonial:ViewComponent
    {
        TestiMonialManager manager = new TestiMonialManager(new EfTestimonialRepository());
        public IViewComponentResult Invoke()
        {
            return View(manager.GetAll());
        }
    }
}
