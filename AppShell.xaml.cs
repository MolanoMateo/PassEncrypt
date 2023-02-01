using ProyectoPassword.View;
using ProyectoPassword.ViewModel;

namespace ProyectoPassword;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		this.BindingContext = new AppShellViewModel();
		Routing.RegisterRoute(nameof(HomePage),typeof(HomePage));
        Routing.RegisterRoute(nameof(PassPage), typeof(PassPage));
        Routing.RegisterRoute(nameof(NewPassPage), typeof(NewPassPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
    }
}
