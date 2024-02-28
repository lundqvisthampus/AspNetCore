using AspNetCore_MVC.Models.Views;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AspNetCore_MVC.Controllers;

public class AuthController(UserService userService) : Controller
{
    private readonly UserService _userService = userService;

    [HttpGet]
    [Route("/signup")]
    public IActionResult SignUp ()
    {
        var viewModel = new AuthSignUpViewModel();
        return View(viewModel);
    }

    [HttpPost]
    [Route("/signup")]
    public async Task<IActionResult> SignUp(AuthSignUpViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var result = await _userService.CreateUserAsync(viewModel.Form);
            if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
                return RedirectToAction("SignIn", "Auth");
        }

        return View(viewModel);
    }

    [HttpGet]
    [Route("/signin")]
    public IActionResult SignIn()
    {
        var viewModel = new AuthSignInViewModel();
        viewModel.ErrorMessage = "";
        return View(viewModel);
    }

    [HttpPost]
    [Route("/signin")]
    public async Task<IActionResult> SignIn(AuthSignInViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var userModel = await _userService.SignInUserAsync(viewModel.SignInModel);
            if (userModel != null)
            {
                var claims = new List<Claim>
                {
                    new (ClaimTypes.NameIdentifier, userModel.Id.ToString()),
                    new (ClaimTypes.Name, userModel.Email),
                    new (ClaimTypes.Email, userModel.Email)
                };

                await HttpContext.SignInAsync("AuthCookie", new ClaimsPrincipal(new ClaimsIdentity(claims, "AuthCookie")));
                return RedirectToAction("Index", "Account");
            }
        }

        viewModel.ErrorMessage = "Incorrect email or password";
        return View(viewModel);
    }

    [HttpGet]
    public new async Task<IActionResult> SignOut()
    {
        await HttpContext.SignOutAsync();
        return RedirectToAction("Index", "Account");
    }
}
