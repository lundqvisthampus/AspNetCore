using AspNetCore_MVC.Models.Components;

namespace AspNetCore_MVC.Models.Sections;

public class ToolsViewModel
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public List<ToolViewModel> Tools { get; set; } = null!;
}
