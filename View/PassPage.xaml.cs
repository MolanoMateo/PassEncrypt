using Microsoft.Toolkit.Mvvm.Input;
using ProyectoPassword.ViewModel;
namespace ProyectoPassword.View;

public partial class PassPage : ContentPage
{
	PassPageViewModel passPageViewModel;
	public PassPage()
	{
		InitializeComponent();
		this.BindingContext = passPageViewModel=new PassPageViewModel(Navigation);
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
        passPageViewModel.OnAppearing();
	}
}