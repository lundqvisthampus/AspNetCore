﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    [Display(Name = "First name")]
    [ProtectedPersonalData]
    public string FirstName { get; set; } = null!;

    [Required]
    [Display(Name = "Last name")]
    [ProtectedPersonalData]
    public string LastName { get; set; } = null!;

    [ProtectedPersonalData]
    public string? Bio { get; set; }
    public ICollection<AddressModel> Address { get; set; } = new List<AddressModel>();

    public bool IsExternalAccount { get; set; } = false;
    public ICollection<CourseModel> Course { get; set; } = new List<CourseModel>();
    public string? ProfileImage { get; set; } = "profile-img.svg";
}
