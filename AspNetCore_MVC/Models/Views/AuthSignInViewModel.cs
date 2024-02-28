using Infrastructure.Models;

namespace AspNetCore_MVC.Models.Views;

public class AuthSignInViewModel
{
    public string Title { get; set; } = "Sign in";
    public SignInModel SignInModel { get; set; } = new SignInModel ();
    public string? ErrorMessage { get; set; }
}
