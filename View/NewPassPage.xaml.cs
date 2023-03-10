using ProyectoPassword.ViewModel;
using ProyectoPassword.Models;

namespace ProyectoPassword.View;

public partial class NewPassPage : ContentPage
{
	public PasSword PasSword { get; set; }
	public NewPassPage()
	{
		InitializeComponent();
		this.BindingContext = new NewPassViewModel();
	}
    public NewPassPage(PasSword passinfo)
    {
        InitializeComponent();
        this.BindingContext = new NewPassViewModel();
		if(passinfo != null)
		{
			((NewPassViewModel)BindingContext).PasSword = passinfo;
		}
    }

}