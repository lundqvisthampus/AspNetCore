using AspNetCore_MVC.Models.Components;
using AspNetCore_MVC.Models.Sections;
using Infrastructures.Models;
using System.Security.Permissions;

namespace AspNetCore_MVC.Models.Views;

public class CoursesIndexViewModel
{
    public IEnumerable<CourseModel> Courses { get; set; } = new List<CourseModel>();
    public CoursesWorkWithUsViewModel WorkWithUs { get; set; } = new CoursesWorkWithUsViewModel
    {
        Text = "Ready to get started?",
        Header = "Take Your <span>Skills</span> to the Next Level",
        ImageUrl = "/images/work-with-us.svg",
        ImageAltText = "Woman at a desk with her laptop",
        ButtonAction = "Index",
        ButtonController = "Contact",
        ButtonText = "Work with us"
    };
    public CourseModel SingleCourse { get; set; } = new CourseModel();
    public IEnumerable<CourseModel> SavedCourses { get; set; } = new List<CourseModel>();
    public int totalCourses { get; set; }
}
