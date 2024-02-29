﻿using AspNetCore_MVC.Models.Views;
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
        }

        return View(model);
    }


    [Route("/signin")]
    public IActionResult SignIn()
    {
        return View();
    }

    [HttpPost]
    [Route("/signin")]
    public async Task<IActionResult> SignIn(AuthSignInViewModel model)
    {
        if (ModelState.IsValid)
        {
            var signInResul = await _signInManager.PasswordSignInAsync(model.SignInModel.Email, model.SignInModel.Password, false, false);
            if (signInResul.Succeeded)
            {
                return RedirectToAction("Index", "Account");
            }
        }

        ViewData["ErrorMessage"] = "Incorrect email or password";
        return View(model);
    }
}
