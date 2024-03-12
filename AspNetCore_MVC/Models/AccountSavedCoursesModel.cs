using AspNetCore_MVC.Models.Components;

namespace AspNetCore_MVC.Models;

public class AccountSavedCoursesModel
{
    public List<CoursesViewModel> SavedCourses { get; set; } = new();
}
