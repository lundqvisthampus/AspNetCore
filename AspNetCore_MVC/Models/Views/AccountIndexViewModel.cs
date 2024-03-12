using AspNetCore_MVC.Models.Components;

namespace AspNetCore_MVC.Models.Views;

public class AccountIndexViewModel
{
    public string Title { get; set; } = "Account Details";
    public ProfileInfoModel ProfileInfo { get; set; } = new ProfileInfoModel();
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel();
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
    public AccountSecurityPasswordModel SecurityPasswordModel { get; set; } = new AccountSecurityPasswordModel();
    public AccountSecurityDeleteModel SecurityDeleteModel { get; set; } = new AccountSecurityDeleteModel();
    public AccountSavedCoursesModel SavedCoursesModel { get; set; } = new AccountSavedCoursesModel 
    { 
        SavedCourses = new List<CoursesViewModel>
        {
            new CoursesViewModel
            {
                ImageUrl = "/images/course-img.svg",
                ImageAltText = "Course Image",
                ControllerName = "Home",
                ActionName = "Index",
                Title = "Fullstack Web Developer Course from Scratch",
                Author = "Robert Fox",
                Price = "12.50",
                CourseHours = "220",
                CourseRating = "94% (4.2K)"
            },

            new CoursesViewModel
            {
                ImageUrl = "/images/course-img.svg",
                ImageAltText = "Course Image",
                ControllerName = "Home",
                ActionName = "Index",
                Title = "Fullstack Web Developer Course from Scratch",
                Author = "Robert Fox",
                Price = "12.50",
                CourseHours = "220",
                CourseRating = "94% (4.2K)"
            },

            new CoursesViewModel
            {
                ImageUrl = "/images/course-img.svg",
                ImageAltText = "Course Image",
                ControllerName = "Home",
                ActionName = "Index",
                Title = "Fullstack Web Developer Course from Scratch",
                Author = "Robert Fox",
                Price = "12.50",
                CourseHours = "220",
                CourseRating = "94% (4.2K)"
            }
        }
    };
}
