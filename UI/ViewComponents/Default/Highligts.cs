using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class Highligts : ViewComponent
    {
        HighlightsManager highlightsManager = new HighlightsManager(new EfHighlightsRepository());
        public IViewComponentResult Invoke()
        {
            return View(highlightsManager.GetAll());
        }
    }
}
