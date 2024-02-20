using AspNetCore_MVC.Models.Components;

namespace AspNetCore_MVC.Models.Sections;

public class IntegrateViewModel
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public List<IntegrationAppViewModel> Applications { get; set; } = null!;
}
