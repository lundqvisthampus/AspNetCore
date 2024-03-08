using Infrastructures.Helpers;

namespace AspNetCore_MVC.Models;

public class AccountSecurityDeleteModel
{
    [CheckboxRequired(ErrorMessage = "Required to delete account")]
    public bool confirmDelete { get; set; } = false;
}
