using AspNetCore_MVC.Models.Views;
using Infrastructures.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

[Authorize]
public class AccountController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);

        var model = new AccountIndexViewModel();
        model.BasicInfo.FirstName = user!.FirstName;
        model.BasicInfo.LastName = user!.LastName;
        model.BasicInfo.Email = user.Email!;

        ViewData["Title"] = "Account Details";
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> BasicInfo(AccountIndexViewModel model)
    {
        return RedirectToAction("Index", "Account");
    }

    [HttpPost]
    public IActionResult AddressInfo(AccountIndexViewModel model)
    {
        return RedirectToAction("Index", "Account");
    }

    public async Task<IActionResult> Security()
    {
        var user = await _userManager.GetUserAsync(User);

        var model = new AccountIndexViewModel();
        model.BasicInfo.FirstName = user!.FirstName;
        model.BasicInfo.LastName = user!.LastName;
        model.BasicInfo.Email = user.Email!;

        ViewData["Title"] = "Account Security";
        return View(model);
    }
}
