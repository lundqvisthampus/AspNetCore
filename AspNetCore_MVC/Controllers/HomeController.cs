using AspNetCore_MVC.Models.Components;
using AspNetCore_MVC.Models.Sections;
using AspNetCore_MVC.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeIndexViewModel();

        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    [Route("/error")]
    public IActionResult Error()
    {
        ViewData["Title"] = "Error";
        return View();
    }
}
