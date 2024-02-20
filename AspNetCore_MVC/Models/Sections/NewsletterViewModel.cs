using AspNetCore_MVC.Models.Components;

namespace AspNetCore_MVC.Models.Sections;

public class NewsletterViewModel
{
    public string Title { get; set; } = null!;
    public ImageViewModel Image { get; set; } = null!;
    public List<NewsCheckboxViewModel> Checkboxes { get; set; } = null!;
}
