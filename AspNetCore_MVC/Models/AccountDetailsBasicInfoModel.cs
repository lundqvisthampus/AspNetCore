using System.ComponentModel.DataAnnotations;

namespace AspNetCore_MVC.Models;

public class AccountDetailsBasicInfoModel
{
    [DataType(DataType.ImageUrl)]
    public string? ProfileImage { get; set; }

    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "First name required")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Last name required")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Email", Prompt = "Enter your email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email required")]
    [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [Display(Name = "Phone", Prompt = "Enter your phone number", Order = 3)]
    [DataType(DataType.PhoneNumber)]
    public string? Phone {  get; set; }

    [Display(Name = "Bio", Prompt = "Add a short bio...", Order = 4)]
    [DataType(DataType.MultilineText)]
    public string? Biography { get; set; }

    public bool IsExternalAccount { get; set; }
}
