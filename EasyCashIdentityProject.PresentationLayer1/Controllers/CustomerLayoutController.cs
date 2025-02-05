using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer1.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
