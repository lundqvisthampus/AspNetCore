using AspNetCore_MVC.Models.Views;
using Infrastructures.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace AspNetCore_MVC.Controllers;

public class AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) : Controller
{
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    private readonly SignInManager<ApplicationUser> _signInManager = signInManager;


    [Route("/signup")]
    public IActionResult SignUp()
    {
        if (_signInManager.IsSignedIn(User))
            return RedirectToAction("Index", "Account");

        return View();
    }

    [HttpPost]
    [Route("/signup")]
    public async Task<IActionResult> SignUp(AuthSignUpViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (!await _userManager.Users.AnyAsync(x => x.Email == model.Form.Email))
            {
                var applicationUser = new ApplicationUser
                {
                    Email = model.Form.Email,
                    FirstName = model.Form.FirstName,
                    LastName = model.Form.LastName,
                    UserName = model.Form.Email
                };

                var signUpResult = await _userManager.CreateAsync(applicationUser, model.Form.Password);
                if (signUpResult.Succeeded)
                {
                    var signInResul = await _signInManager.PasswordSignInAsync(applicationUser, model.Form.Password, false, false);
                    if (signInResul.Succeeded)
                    {
                        return RedirectToAction("Index", "Account");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("AlreadyExists", "Email address is already registered");
                ViewData["ErrorMessage"] = "Email address is already registered";
                return View(model);
            }
        }

        return View(model);
    }


    [Route("/signin")]
    public IActionResult SignIn()
    {
        if (_signInManager.IsSignedIn(User))
            return RedirectToAction("Index", "Account");

        return View();
    }

    [HttpPost]
    [Route("/signin")]
    public async Task<IActionResult> SignIn(AuthSignInViewModel model)
    {
        if (ModelState.IsValid)
        {
            var signInResul = await _signInManager.PasswordSignInAsync(model.SignInModel.Email, model.SignInModel.Password, model.SignInModel.RememberMe, false);
            if (signInResul.Succeeded)
            {
                return RedirectToAction("Index", "Account");
            }
        }

        ViewData["ErrorMessage"] = "Incorrect email or password";
        return View(model);
    }

    [Route("/signout")]
    public new async Task<IActionResult> SignOut()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }


    [HttpGet]
    public IActionResult Facebook()
    {
        var authProps = _signInManager.ConfigureExternalAuthenticationProperties("Facebook", Url.Action("FacebookCallback"));
        return new ChallengeResult("Facebook", authProps);
    }

    [HttpGet]
    public async Task<IActionResult> FacebookCallBack()
    {
        var info = await _signInManager.GetExternalLoginInfoAsync();
        if (info != null)
        {
            var userModel = new ApplicationUser
            {
                FirstName = info.Principal.FindFirstValue(ClaimTypes.GivenName)!,
                LastName = info.Principal.FindFirstValue(ClaimTypes.Surname)!,
                Email = info.Principal.FindFirstValue(ClaimTypes.Email)!,
                UserName = info.Principal.FindFirstValue(ClaimTypes.Email)!,
                IsExternalAccount = true
            };

            var user = await _userManager.FindByEmailAsync(userModel.Email);
            if (user == null)
            {
                var result = await _userManager.CreateAsync(userModel);
                if (result.Succeeded)
                {
                    user = await _userManager.FindByEmailAsync(userModel.Email);
                }
            }
            
            if (user != null) 
            {
                if (user.FirstName != userModel.FirstName || user.LastName != userModel.LastName || user.Email != userModel.Email)
                {
                    user.FirstName = userModel.FirstName;
                    user.LastName = userModel.LastName;
                    user.Email = userModel.Email;
                    user.IsExternalAccount = true;

                    await _userManager.UpdateAsync(user);
                }

                await _signInManager.SignInAsync(user, isPersistent: false);

                if (HttpContext.User != null)
                {
                    return RedirectToAction("Index", "Account");
                }
            }
        }

        return RedirectToAction("SignIn", "Auth");
    }
}
