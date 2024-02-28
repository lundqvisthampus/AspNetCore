using Infrastructure.Models;

namespace AspNetCore_MVC.Models.Views;

public class AuthSignUpViewModel
{
    public string Title { get; set; } = "Sign up";
    public SignUpModel Form { get; set; } = new SignUpModel ();
}
