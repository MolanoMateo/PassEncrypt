using ProyectoPassword.ViewModel;
namespace ProyectoPassword;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel loginPageViewModel)
	{
		InitializeComponent();
		this.BindingContext= loginPageViewModel;
	}


	private async void Login_Clicked(object sender, EventArgs e)
	{
		string userName = txtUserName.Text;
		string password = txtPassword.Text;
		if(userName == null || password == null)
		{
			await DisplayAlert("Warning", "Ingrese la información", "OK");
			return;
		}
	}
}