using AspNetCore_MVC.Models;
using AspNetCore_MVC.Models.Views;
using Infrastructures.Models;
using Infrastructures.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

[Authorize]
public class AccountController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly AddressManager _addressManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AddressManager addressManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _addressManager = addressManager;
    }

    #region Index
    public async Task<IActionResult> Index()
    {
        var model = await PopulateBasicInfoAsync();
        model.ProfileInfo = await PopulateProfileInfoAsync();
        model.AddressInfo = await PopulateAddressInfoAsync();

        ViewData["Title"] = "Account Details";
        return View(model);
    }
    #endregion


    #region SaveBasicInfo
    [HttpPost]
    public async Task<IActionResult> SaveBasicInfo(AccountDetailsBasicInfoModel basicInfoModel)
    {
        var user = await _userManager.GetUserAsync(User);

        if (!user!.IsExternalAccount)
        {
            if (TryValidateModel(basicInfoModel))
            {
                if (basicInfoModel != null)
                {
                    user.FirstName = basicInfoModel.FirstName;
                    user.LastName = basicInfoModel.LastName;
                    user.Email = basicInfoModel.Email;
                    user.PhoneNumber = basicInfoModel.Phone;
                    user.Bio = basicInfoModel.Biography;

                    await _userManager.UpdateAsync(user);
                }
            }
        }
        else
        {
            if (basicInfoModel != null)
            {
                user.PhoneNumber = basicInfoModel.Phone;
                user.Bio = basicInfoModel.Biography;
                await _userManager.UpdateAsync(user);

                basicInfoModel.FirstName = user.FirstName;
                basicInfoModel.LastName = user.LastName;
                basicInfoModel.Email = user.Email!;
            }
        }


        var newModel = new AccountIndexViewModel { BasicInfo = basicInfoModel! };
        newModel.ProfileInfo = await PopulateProfileInfoAsync();
        newModel.AddressInfo = await PopulateAddressInfoAsync();
        return View("index", newModel);
    }
    #endregion


    #region SaveAddressInfo
    [HttpPost]
    public async Task<IActionResult> SaveAddressInfo(AccountDetailsAddressInfoModel addressInfoModel)
    {
        if (TryValidateModel(addressInfoModel))
        {
            if (addressInfoModel != null)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    var address = await _addressManager.GetAddressAsync(user.Id);
                    if (address != null)
                    {
                        address.AddressLine_1 = addressInfoModel.Addressline_1;
                        address.AddressLine_2 = addressInfoModel.Addressline_2;
                        address.PostalCode = addressInfoModel.PostalCode;
                        address.City = addressInfoModel.City;
                        await _addressManager.UpdateAddressAsync(address);
                    }
                    else
                    {
                        address = new AddressModel
                        {
                            UserId = user.Id,
                            AddressLine_1 = addressInfoModel.Addressline_1,
                            AddressLine_2 = addressInfoModel.Addressline_2,
                            PostalCode = addressInfoModel.PostalCode,
                            City = addressInfoModel.City,
                        };
                        await _addressManager.CreateAddressAsync(address);
                    }
                }
            }
        }

        var newModel = new AccountIndexViewModel { AddressInfo = addressInfoModel! };
        newModel.ProfileInfo = await PopulateProfileInfoAsync();
        var infoModel = await PopulateBasicInfoAsync();
        newModel.BasicInfo = infoModel.BasicInfo;
        newModel.AddressInfo = await PopulateAddressInfoAsync();
        return View("Index", newModel);
    }
    #endregion


    #region Security
    public async Task<IActionResult> Security()
    {
        var model = new AccountIndexViewModel();
        model.ProfileInfo = await PopulateProfileInfoAsync();

        ViewData["Title"] = "Account Security";
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Security(AccountSecurityPasswordModel passwordModel)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null) 
            {
                var result = await _userManager.ChangePasswordAsync(user, passwordModel.currentPassword, passwordModel.newPassword);
                if (result.Succeeded)
                {
                    ViewData["PasswordChanged"] = "Your password was successfully updated!";
                }
                else
                {
                    ViewData["PasswordChanged"] = "Something went wrong, password was not updated.";
                }
            }
        }

        var model = new AccountIndexViewModel();
        model.ProfileInfo = await PopulateProfileInfoAsync();
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteAccount(AccountSecurityDeleteModel model) 
    { 
        if (ModelState.IsValid)
        {
            if (model != null)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    var result = await _addressManager.DeleteAddressAsync(user.Id);
                    if (result)
                    {
                        await _userManager.DeleteAsync(user);
                    }
                    await _userManager.DeleteAsync(user);
                }
            }
        }
        else
        {
            var newModel = new AccountIndexViewModel();
            newModel.ProfileInfo = await PopulateProfileInfoAsync();
            return View("Security", newModel);
        }

        TempData["WasDeleted"] = "Your account was successfully deleted";
        return RedirectToAction("Signin", "Auth"); 
    }
    #endregion


    #region Populate Info Methods
    private async Task<ProfileInfoModel> PopulateProfileInfoAsync()
    {
        var user = await _userManager.GetUserAsync(User);

        var profileInfo = new ProfileInfoModel
        {
            FirstName = user!.FirstName,
            LastName = user.LastName,
            Email = user.Email!,
        };

        return profileInfo;
    }

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
            Biography = user.Bio,
            IsExternalAccount = user.IsExternalAccount
        };
        return viewModel;
    }

    private async Task<AccountDetailsAddressInfoModel> PopulateAddressInfoAsync()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user != null)
        {
            var address = await _addressManager.GetAddressAsync(user!.Id);
            if (address != null)
            {
                var addressInfo = new AccountDetailsAddressInfoModel
                {
                    Addressline_1 = address.AddressLine_1,
                    Addressline_2 = address.AddressLine_2,
                    PostalCode = address.PostalCode,
                    City = address.City
                };
                return addressInfo;
            }
        }
        return new AccountDetailsAddressInfoModel();
    }
}
#endregion