using AspNetCore_MVC.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        var model = new AccountIndexViewModel();
        ViewData["Title"] = "Account Details";
        return View(model);
    }

    [HttpPost]
    public IActionResult BasicInfo(AccountIndexViewModel model)
    {
        return RedirectToAction("Index", "Account");
    }

    [HttpPost]
    public IActionResult AddressInfo(AccountIndexViewModel model)
    {
        return RedirectToAction("Index", "Account");
    }
}
