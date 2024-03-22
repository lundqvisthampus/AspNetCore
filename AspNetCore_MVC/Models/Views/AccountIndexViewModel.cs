using AspNetCore_MVC.Models.Components;
using AspNetCore_MVC.Models.Sections;
using Infrastructures.Models;

namespace AspNetCore_MVC.Models.Views;

public class AccountIndexViewModel
{
    public string Title { get; set; } = "Account Details";
    public ProfileInfoModel ProfileInfo { get; set; } = new ProfileInfoModel();
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel();
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
    public AccountSecurityPasswordModel SecurityPasswordModel { get; set; } = new AccountSecurityPasswordModel();
    public AccountSecurityDeleteModel SecurityDeleteModel { get; set; } = new AccountSecurityDeleteModel();
    public AccountSavedCoursesModel SavedCoursesModel { get; set; } = new AccountSavedCoursesModel();
}
