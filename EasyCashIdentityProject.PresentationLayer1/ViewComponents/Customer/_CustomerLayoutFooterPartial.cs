using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer1.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
