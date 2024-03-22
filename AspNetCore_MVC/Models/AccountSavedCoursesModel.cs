using AspNetCore_MVC.Models.Components;
using AspNetCore_MVC.Models.Sections;
using Infrastructures.Models;

namespace AspNetCore_MVC.Models;

public class AccountSavedCoursesModel
{
    public List<CourseModel> SavedCourses { get; set; } = new();
}
