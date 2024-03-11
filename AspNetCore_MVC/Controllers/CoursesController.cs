using AspNetCore_MVC.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

public class CoursesController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new CoursesIndexViewModel();

        ViewData["Title"] = "All Our Courses";
        return View(viewModel);
    }
}
