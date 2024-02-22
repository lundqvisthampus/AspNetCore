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

    [HttpGet]
    public IActionResult SignIn()
    {
        ViewData["Title"] = "Sign in";
        var viewModel = new AuthSignInViewModel();
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult SignIn(AuthSignInViewModel viewModel)
    {
        ViewData["Title"] = "Sign in";
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        viewModel.ErrorMessage = "Incorrect email or password";
        return View(viewModel);
    }
}
