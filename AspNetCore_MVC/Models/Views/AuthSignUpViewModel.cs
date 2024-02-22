namespace AspNetCore_MVC.Models.Views;

public class AuthSignUpViewModel
{
    public string Title { get; set; } = "Sign up";
    public SignUpFormModel Form { get; set; } = new SignUpFormModel();
}
