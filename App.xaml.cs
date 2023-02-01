using ProyectoPassword.Models;
using ProyectoPassword.Services.PassService;

namespace ProyectoPassword;

public partial class App : Application
{
	public static PassService _passService;
	public static PassService PassService
	{
		get
		{
			if(_passService == null)
			{
				_passService = new PassService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordDB.db3"),null);
			}
			return _passService;
		}
	}
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
