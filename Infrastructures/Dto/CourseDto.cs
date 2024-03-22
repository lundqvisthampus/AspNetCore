namespace Infrastructures.Dto;

public class CourseDto
{
    public string Title { get; set; } = null!;
    public string Price { get; set; } = null!;
    public string? DiscountPrice { get; set; }
    public string CourseHours { get; set; } = null!;
    public string CourseImgUrl { get; set; } = null!;
    public string LikesNumber { get; set; } = null!;
    public string LikesProcent { get; set; } = null!;
    public string Author { get; set; } = null!;
    public bool IsBestSeller { get; set; } = false;
    public bool IsDigital { get; set; } = false;
    public string? AuthorYtSubs { get; set; }
    public string? AuthorFbFollowers { get; set; }
}
