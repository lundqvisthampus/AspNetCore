
using AspNetCore_MVC.Models.Components;

namespace AspNetCore_MVC.Models.Sections;

public class ShowcaseViewModel
{
    public string Title { get; set; } = null!;
    public string FirstText { get; set; } = null!;
    public string SecondText { get; set; } = null!;
    public LinkViewModel Link { get; set; } = new LinkViewModel();
    public string BrandsText { get; set; } = null!;
    public List<ImageViewModel> Brands { get; set; } = null!;
}
