namespace AspNetCore_MVC.Models.Views;

public class AccountIndexViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel() 
    {
        ProfileImage = "/images/profile-img.svg",
    };
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
}
