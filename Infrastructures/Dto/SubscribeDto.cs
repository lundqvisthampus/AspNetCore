using System.ComponentModel.DataAnnotations;

namespace Infrastructures.Dto;

public class SubscribeDto
{
    [Required]
    [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;
    public bool DailyNewsletter { get; set; } = false;
    public bool AdvertisingUpdates { get; set; } = false;
    public bool WeekInReview { get; set; } = false;
    public bool EventUpdates { get; set; } = false;
    public bool StartupsWeekly { get; set; } = false;
    public bool Podcasts { get; set; } = false;
}
