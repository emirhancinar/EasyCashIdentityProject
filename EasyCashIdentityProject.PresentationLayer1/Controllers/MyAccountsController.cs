using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer1.Controllers
{
    public class MyAccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
