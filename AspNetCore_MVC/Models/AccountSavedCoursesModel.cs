using AspNetCore_MVC.Models.Components;
using AspNetCore_MVC.Models.Sections;

namespace AspNetCore_MVC.Models;

public class AccountSavedCoursesModel
{
    public List<SingleCourseViewModel> SavedCourses { get; set; } = new();
}
