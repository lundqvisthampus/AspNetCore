namespace AspNetCore_MVC.Models.Components
{
    public class CourseIncludesViewModel
    {
        public string HoursOfContent { get; set; } = null!;
        public string AmountOfArticles { get; set; } = null!;
        public string DownloadableResources { get; set; } = null!;
        public bool LifetimeAccess { get; set; } = false;
        public bool Certificate { get; set; } = false;
        public string Price { get; set; } = null!;
        public string? ReducedPrice { get; set; }
    }
}
