namespace AspNetCore_MVC.Models.Components;

public class DownloadAppViewModel
{
    public string Store { get; set; } = null!;
    public int StarsAmount { get; set; }
    public string AppTitle { get; set; } = null!;
    public string RatingText { get; set; } = null!;
    public ImageViewModel StoreImage { get; set; } = null!;
}
