using AspNetCore_MVC.Models.Sections;
using AspNetCore_MVC.Models.Views;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

public class CoursesController : Controller
{
    [Authorize]
    public IActionResult Index()
    {
        var viewModel = new CoursesIndexViewModel();

        ViewData["Title"] = "All Our Courses";
        return View(viewModel);
    }

    [Authorize]
    public IActionResult SingleCourse()
    {
        var viewModel = new CoursesIndexViewModel();

        ViewData["Title"] = "One of our courses";
        return View(viewModel);
    }
}
