﻿using EasyCashIdentityProject.EntityLayer.Concete;
using EasyCashIdentityProject.PresentationLayer1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer1.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName,loginViewModel.Password,false,true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(loginViewModel.UserName);

                if (user.EmailConfirmed == true)
                {
                    return RedirectToAction("Index", "MyAccounts");
                }
                //else lütfen mail adresinizi onayla
            }
            //Kullanıcı adı veya şifre hatalı

            return View();
        }

    }
}
