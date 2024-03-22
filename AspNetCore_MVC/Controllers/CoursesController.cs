using AspNetCore_MVC.Models.Sections;
using AspNetCore_MVC.Models.Views;
using Infrastructures.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Nodes;

namespace AspNetCore_MVC.Controllers;

public class CoursesController : Controller
{
    [Authorize]
    public async Task<IActionResult> Index()
    {
        using var client = new HttpClient();
        var response = await client.GetAsync("https://localhost:7023/api/Course/all");
        var json = await response.Content.ReadAsStringAsync();
        var coursesList = JsonConvert.DeserializeObject<IEnumerable<CourseModel>>(json);

        var viewModel = new CoursesIndexViewModel();
        if (coursesList!.Any())
        {
            viewModel.Courses = coursesList!;
        }

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
