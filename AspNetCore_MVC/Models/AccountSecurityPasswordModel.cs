using System.ComponentModel.DataAnnotations;

namespace AspNetCore_MVC.Models;

public class AccountSecurityPasswordModel
{
    [Display(Name = "Current Password", Prompt = "********", Order = 0)]
    [Required(ErrorMessage = "Enter current password")]
    [DataType(DataType.Password)]
    public string currentPassword { get; set; } = null!;


    [Display(Name = "New password", Prompt = "********", Order = 1)]
    [Required(ErrorMessage = "Enter new password")]
    [DataType(DataType.Password)]
    public string newPassword { get; set; } = null!;

    [Display(Name = "Confirm new password", Prompt = "********", Order = 1)]
    [Required(ErrorMessage = "Confirm password")]
    [DataType(DataType.Password)]
    [Compare(nameof(newPassword), ErrorMessage = "Password does not match")]
    public string confirmNewPassword { get; set; } = null!;
}
