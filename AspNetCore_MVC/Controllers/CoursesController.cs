using AspNetCore_MVC.Models.Sections;
using AspNetCore_MVC.Models.Views;
using Infrastructures.Contexts;
using Infrastructures.Migrations;
using Infrastructures.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Nodes;

namespace AspNetCore_MVC.Controllers;

public class CoursesController(SignInManager<ApplicationUser> signInManager, DataContext context) : Controller
{
    private readonly SignInManager<ApplicationUser> _signInManager = signInManager;
    private readonly DataContext _context = context;


    [Authorize]
    public async Task<IActionResult> Index()
    {
        using var client = new HttpClient();
        var response = await client.GetAsync("https://localhost:7023/api/Course/all?key=44ee639f-12d8-4847-a560-0604cc38cd57");
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
    public async Task<IActionResult> SingleCourse(int id)
    {
        using var client = new HttpClient();
        var response = await client.GetAsync($"https://localhost:7023/api/Course/{id}?key=44ee639f-12d8-4847-a560-0604cc38cd57");
        if (!response.IsSuccessStatusCode)
        {
            return RedirectToAction("Error", "Home");
        }

        var json = await response.Content.ReadAsStringAsync();
        var course = JsonConvert.DeserializeObject<CourseModel>(json);

        var viewModel = new CoursesIndexViewModel();

        if (course != null)
        {
            viewModel.SingleCourse = course;
        }

        ViewData["Title"] = "One of our courses";
        return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> SaveCourse(int courseId)
    {
        var user = await _signInManager.UserManager.GetUserAsync(User);

        var userCourse = new UserCourseModel
        {
            CourseId = courseId,
            UserId = user!.Id
        };

        _context.SavedCourses.Add(userCourse);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index", "Courses");
    }
}
