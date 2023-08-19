using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace UI.ViewComponents.Default
{
    public class PopulerDestination : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationReposityory());
        public IViewComponentResult Invoke()
        {
            return View(destinationManager.GetAll());
        }
    }
}
