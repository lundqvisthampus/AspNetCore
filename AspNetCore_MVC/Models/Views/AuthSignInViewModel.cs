namespace AspNetCore_MVC.Models.Views;

public class AuthSignInViewModel
{
    public string Title { get; set; } = "Sign in";
    public SignInFormModel SignInModel { get; set; } = new SignInFormModel();
    public string? ErrorMessage { get; set; }
}
