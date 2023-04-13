using CRM_mvc.Models.Entities;
using CRM_mvc.Models.Views.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CRM_mvc.Controllers;

public class AuthController : Controller
{
    private readonly SignInManager<User> signInManager;

    public AuthController(SignInManager<User> signInManager)
    {
        this.signInManager = signInManager;
    }

    [Route("/login", Name = "login")]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Route("/login", Name = "login")]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var Result = await signInManager.PasswordSignInAsync(model.Email, model.Password, true, false);
            if (Result.Succeeded)
            {
                return RedirectToAction("index", "Call");
            }
            ViewBag.ErrorLogin = false;
        }
        return View(model);
    }

    public IActionResult ChangePassword()
    {
        return View();
    }
}