using AspNetCore_MVC.Models.Components;

namespace AspNetCore_MVC.Models.Sections;

public class SingleCourseViewModel
{
    public string? ControllerName { get; set; }
    public string? ActionName { get; set; }
    public string CourseImgUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Ingress { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int StarsAmount { get; set; }
    public string ReviewsAmount { get; set; } = null!;
    public string LikesAmount { get; set; } = null!;
    public string HoursContent { get; set; } = null!;
    public bool IsBestSeller { get; set; } = false;
    public bool IsDigital { get; set; } = false;
    public CourseAuthorViewModel Author { get; set; } = new CourseAuthorViewModel();
    public List<CourseLearningViewModel> Learning { get; set; } = new List<CourseLearningViewModel>();
    public CourseIncludesViewModel Includes { get; set; } = new CourseIncludesViewModel();
    public List<CourseDetailsViewModel> Details { get; set; } = new List<CourseDetailsViewModel>();
}
