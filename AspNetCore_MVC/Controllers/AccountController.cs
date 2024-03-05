using AspNetCore_MVC.Models;
using AspNetCore_MVC.Models.Views;
using Infrastructures.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

[Authorize]
public class AccountController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    #region Index
    public async Task<IActionResult> Index()
    {
        var model = await PopulateBasicInfoAsync();


        ViewData["Title"] = "Account Details";
        return View(model);
    }
    #endregion


    #region SaveBasicInfo
    [HttpPost]
    public IActionResult SaveBasicInfo(AccountDetailsBasicInfoModel basicInfoModel)
    {
        if (TryValidateModel(basicInfoModel)) 
        {
            return RedirectToAction("Index", "Home");
        }

        var newModel = new AccountIndexViewModel { BasicInfo = basicInfoModel };
        return View("Index", newModel);
    }
    #endregion


    #region SaveAddressInfo
    [HttpPost]
    public async Task<IActionResult> SaveAddressInfo(AccountDetailsAddressInfoModel addressInfoModel)
    {
        if (TryValidateModel(addressInfoModel))
        {
            return RedirectToAction("Index", "Home");
        }

        var populateModel = await PopulateBasicInfoAsync();
        populateModel.AddressInfo = addressInfoModel;
        return View("Index", populateModel);
    }
    #endregion


    #region Security
    public async Task<IActionResult> Security()
    {
        var user = await _userManager.GetUserAsync(User);

        var model = new AccountIndexViewModel();
        model.BasicInfo.FirstName = user!.FirstName;
        model.BasicInfo.LastName = user!.LastName;
        model.BasicInfo.Email = user.Email!;

        ViewData["Title"] = "Account Security";
        return View(model);
    }
    #endregion


    private async Task<AccountIndexViewModel> PopulateBasicInfoAsync()
    {
        var user = await _userManager.GetUserAsync(User);

        var viewModel = new AccountIndexViewModel();
        viewModel.BasicInfo = new AccountDetailsBasicInfoModel
        {
            FirstName = user!.FirstName,
            LastName = user.LastName,
            Email = user.Email!,
            Phone = user.PhoneNumber,
            Biography = user.Bio
        };
        return viewModel;
    }

    //private async Task<AccountDetailsAddressInfoModel> PopulateAddressInfoAsync()
    //{
    //    var user = await _userManager.GetUserAsync(User);
    //    var address = user!.Address.FirstOrDefault(x => x.UserId == user.Id);

    //    if (address != null) 
    //    {
    //        var addressInfo = new AccountDetailsAddressInfoModel
    //        {
    //            Addressline_1 = address.AddressLine_1,
    //            Addressline_2 = address.AddressLine_2,
    //            City = address.City,
    //            PostalCode = address.PostalCode
    //        };

    //    }
    //    return null!;
    //}
}
