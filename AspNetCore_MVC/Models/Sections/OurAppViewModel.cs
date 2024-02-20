using AspNetCore_MVC.Models.Components;

namespace AspNetCore_MVC.Models.Sections;

public class OurAppViewModel
{
    public ImageViewModel Image { get; set; } = null!;
    public string Title { get; set; } = null!;
    public List<DownloadAppViewModel> AppStoresList { get; set; } = null!;
}
