namespace AspNetCore_MVC.Models.Components;

public class CoursesViewModel
{
    public string ControllerName { get; set; } = null!;
    public string ActionName { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Price { get; set; } = null!;
    public string CourseHours { get; set; } = null!;
    public string CourseRating { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string ImageAltText { get; set; } = null!;
}
