using System.ComponentModel.DataAnnotations;

namespace Infrastructures.Models;

public class ContactModel
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Full name", Prompt = "Enter your full name")]
    [Required(ErrorMessage = "Name is required")]
    [MinLength(2, ErrorMessage = "Invalid name")]
    public string FullName { get; set; } = null!;

    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "Email required")]
    [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Display(Name = "Service", Prompt = "Choose the service you are interested in")]
    public string? Service { get; set; }

    [Display(Name = "Message", Prompt = "Enter your message here...")]
    [Required(ErrorMessage = "Message is required")]
    [DataType(DataType.MultilineText)]
    [MinLength(20, ErrorMessage = "Message has to be at least 20 characters long.")]
    public string Message { get; set; } = null!;
}
