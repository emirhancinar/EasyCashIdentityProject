﻿using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer1.ViewComponents.Customer
{
    public class _CustomerLayoutHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
