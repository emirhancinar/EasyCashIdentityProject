using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProject.EntityLayer.Concete;
//using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MimeKit;
using System.Net.Mail;
using System.Net;

namespace EasyCashIdentityProject.PresentationLayer1.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		public RegisterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
		{
			if (ModelState.IsValid)
			{
				Random rnd = new Random();
				int randomCode = rnd.Next(100000, 1000000);
				AppUser appUser = new AppUser()
				{
					UserName = appUserRegisterDto.UserName,
					Name = appUserRegisterDto.Name,
					SurName = appUserRegisterDto.Surname,
					Email = appUserRegisterDto.Email,
					City ="aaa",
					District = "bbb",
					ImageUrl = "ccc",
					ConfirmCode = randomCode

				};
				var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
				if (result.Succeeded)
				{
					// E-posta gönderme için SMTP istemcisini oluşturun
					SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
					{
						Port = 587, // Gmail için TLS portu
						Credentials = new NetworkCredential("emirhancinar025@gmail.com", "fgpy hrvf xqyq tcjf"),
						EnableSsl = true, // Güvenli bağlantı gerekiyorsa true yapın
					};
					// E-posta mesajını oluşturun
					MailMessage mailMessage = new MailMessage
					{
						From = new MailAddress("emirhancinar025@gmail.com"),
						Subject = "Easy Code Onay Kodu",
						Body = "Kayıt işlemini gerçekleştirmek için onay kodunuz : " + randomCode,
					};
					mailMessage.To.Add(appUser.Email); // Alıcı e-posta adresi
															   // E-postayı gönder
					smtpClient.Send(mailMessage);

					TempData["Mail"] = appUserRegisterDto.Email;

					return RedirectToAction("Index", "ConfirmMail");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);

                    }
					
				}
			}
			return View();
		}
	}
}
// En az 6 karakterden oluşacak
// En az 1 küçük harf
// En az 1 büyük harf
// En az 1 büyük sembol
// En az 1 sayı içermeli

