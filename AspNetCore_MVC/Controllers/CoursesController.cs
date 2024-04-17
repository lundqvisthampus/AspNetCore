using AspNetCore_MVC.Models.Sections;
using AspNetCore_MVC.Models.Views;
using Infrastructures.Contexts;
using Infrastructures.Migrations;
using Infrastructures.Models;
using Infrastructures.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Nodes;

namespace AspNetCore_MVC.Controllers;

[Authorize]
public class CoursesController(SignInManager<ApplicationUser> signInManager, DataContext context, CourseManager courseManager, CourseJsonManager courseJsonManager) : Controller
{
    private readonly SignInManager<ApplicationUser> _signInManager = signInManager;
    private readonly DataContext _context = context;
    private readonly CourseManager _courseManager = courseManager;
    private readonly CourseJsonManager _courseJsonManager = courseJsonManager;


    public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 9, string? search = null, string? select = null)
    {
        ViewData["Title"] = "All Our Courses";

        if (HttpContext.Request.Cookies.TryGetValue("AccessToken", out var token))
        {
            var fewCoursesList = await _courseJsonManager.TakeFew(pageNumber, pageSize, token);
            var allCoursesList = await _courseJsonManager.TakeAll(token);


            var viewModel = new CoursesIndexViewModel();
            var user = await _signInManager.UserManager.GetUserAsync(User);
            viewModel.SavedCourses = await _courseManager.GetSaved(user);
            viewModel.totalCourses = allCoursesList.Count();

            if (search != null || select != null)
            {
                var searchList = new List<CourseModel>();

                if (search != null)
                {
                    foreach (var course in allCoursesList)
                    {
                        if (course.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                            course.Author.Contains(search, StringComparison.OrdinalIgnoreCase))
                        {
                            searchList.Add(course);
                        }
                    }
                    viewModel.Courses = searchList;
                }
                else if (select != null)
                {
                    foreach (var course in allCoursesList)
                    {
                        switch (select)
                        {
                            case "Best seller":
                                if (course.IsBestSeller == true)
                                    searchList.Add(course);
                                break;

                            case "Reduced price":
                                if (course.DiscountPrice != null && course.DiscountPrice != "string" && course.DiscountPrice != "0")
                                    searchList.Add(course);
                                break;

                            case "Saved courses":
                                searchList = viewModel.SavedCourses.ToList();
                                break;

                            default:
                                searchList = fewCoursesList.ToList();
                                break;
                        }
                    }
                    viewModel.Courses = searchList;
                }
                return View(viewModel);

            }
            else
            {
                if (fewCoursesList!.Any())
                {
                    viewModel.Courses = fewCoursesList!;
                    return View(viewModel);
                }
            }
        }

        return View();
    }


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
        var user = await _signInManager.UserManager.GetUserAsync(User);
        viewModel.SavedCourses = await _courseManager.GetSaved(user);

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
        try
        {
            var user = await _signInManager.UserManager.GetUserAsync(User);
            var userCourse = new UserCourseModel
            {
                CourseId = courseId,
                UserId = user!.Id
            };

            _context.SavedCourses.Add(userCourse);
            await _context.SaveChangesAsync();
        }
        catch
        {

        }

        return RedirectToAction("Index", "Courses");
    }

    [HttpPost]
    public async Task<IActionResult> DeleteCourse(int courseId)
    {
        try
        {
            var user = await _signInManager.UserManager.GetUserAsync(User);
            var userCourse = await _context.SavedCourses.FirstOrDefaultAsync(x => x.UserId == user!.Id && x.CourseId == courseId);

            if (userCourse != null)
            {
                _context.SavedCourses.Remove(userCourse);
                await _context.SaveChangesAsync();
            }
        }
        catch
        {

        }

        return RedirectToAction("Index", "Courses");
    }
}
