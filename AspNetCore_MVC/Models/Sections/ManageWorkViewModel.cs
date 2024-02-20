using AspNetCore_MVC.Models.Components;

namespace AspNetCore_MVC.Models.Sections;

public class ManageWorkViewModel
{
    public ImageViewModel ImageViewModel { get; set; } = null!;
    public string Title { get; set; } = null!;
    public List<ManagingFeaturesViewModel> Features { get; set; } = null!;
    public LinkViewModel Link { get; set; } = null!;
}
