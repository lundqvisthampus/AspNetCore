namespace AspNetCore_MVC.Models.Components;

public class CourseAuthorViewModel
{
    public string AuthorName { get; set; } = null!;
    public string AuthorImgUrl { get; set; } = null!;
    public string AuthorBigImgUrl { get; set; } = null!;
    public string AuthorDescription { get; set; } = null!;
    public string? YoutubeUrl { get; set; }
    public string? YoutubeSubscribers { get; set; }
    public string? FacebookUrl { get; set; }
    public string? FacebookSubscribers {  get; set; }
}
