using System;
using data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TestWeb.Identity.interfaces;
using TestWeb.Options;
using TestWeb.Services.interfaces;
using TestWeb.ViewModels;
using Xceed.Wpf.Toolkit;

namespace TestWeb.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {

        private IAuthenticationUserService _authenticationService;
        private ITokenGenerator _tokenGenerator;
        private readonly IConfiguration _config;

        public AccountController(IConfiguration config, IAuthenticationUserService authenticationService, ITokenGenerator tokenGenerator)
        {
            _authenticationService = authenticationService;
            _tokenGenerator = tokenGenerator;
            _config = config;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserLogin user = _authenticationService.Authenticate(model.LoginName, model.Password);
                if (user != null)
                {
                    user.Token = _tokenGenerator.GenerateToken(user);

                    var section = _config.GetSection("AuthOptions");
                    var jwtOptions = section.Get<AuthOptions>();
                    HttpContext.Response.Cookies.Append(
                        ".AspNetCore.App.Id",
                        user.Token,
                        new CookieOptions { MaxAge = TimeSpan.FromMinutes(jwtOptions.Lifetime) });

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        [Authorize]
        public  IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete(".AspNetCore.App.Id");
            return RedirectToAction("Login", "Account");
        }

    }
}