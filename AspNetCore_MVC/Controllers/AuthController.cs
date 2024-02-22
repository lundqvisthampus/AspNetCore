using AspNetCore_MVC.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

public class AuthController : Controller
{
    [HttpGet]
    public IActionResult SignUp ()
    {
        ViewData["Title"] = "Sign up";
        var viewModel = new AuthSignUpViewModel();
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult SignUp(AuthSignUpViewModel viewModel)
    {
        ViewData["Title"] = "Sign up";
        if (!ModelState.IsValid) 
        {
            return View(viewModel);
        }

        return  RedirectToAction("SignIn", "Auth");
    }
}
