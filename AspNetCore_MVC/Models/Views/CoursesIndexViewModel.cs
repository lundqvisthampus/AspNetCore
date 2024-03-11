using AspNetCore_MVC.Models.Components;

namespace AspNetCore_MVC.Models.Views;

public class CoursesIndexViewModel
{
    public List<CoursesViewModel> Courses { get; set; } = new List<CoursesViewModel>
    {
        new CoursesViewModel
        {
            ImageUrl = "/images/course-img.svg",
            ImageAltText = "Course Image",
            ControllerName = "Home",
            ActionName = "Index",
            Title = "Fullstack Web Developer Course from Scratch",
            Author = "Robert Fox",
            Price = "$12.50",
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
            Price = "$12.50",
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
            Price = "$12.50",
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
            Price = "$12.50",
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
            Price = "$12.50",
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
            Price = "$12.50",
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
            Price = "$12.50",
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
            Price = "$12.50",
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
            Price = "$12.50",
            CourseHours = "220",
            CourseRating = "94% (4.2K)"
        },
    };
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
}
