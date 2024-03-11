﻿using Infrastructures.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.Models;

public class SignUpModel
{
    [DataType(DataType.Text)]
    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "First name required")]
    [MinLength(2, ErrorMessage = "First name required")]
    public string FirstName { get; set; } = null!;

    [DataType(DataType.Text)]
    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Last name required")]
    [MinLength(2, ErrorMessage = "Last name required")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Email", Prompt = "Enter your email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email required")]
    [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [Display(Name = "Password", Prompt = "Enter your password", Order = 3)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password required")]
    [RegularExpression("^(?=.*[^\\w\\s])(?=.*[A-Z]).{8,}$", ErrorMessage = "Invalid password, not strong enough")]
    public string Password { get; set; } = null!;

    [Display(Name = "Confirm password", Prompt = "Confirm your password", Order = 4)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Fields do not match")]
    [Compare(nameof(Password), ErrorMessage = "Fields do not match")]
    public string ConfirmPassword { get; set; } = null!;

    [Display(Name = "I agree to the Terms & Conditions", Order = 5)]
    [CheckboxRequired(ErrorMessage = "You must accept the Terms & Conditions")]
    public bool TermsAndConditions { get; set; } = false;
}
