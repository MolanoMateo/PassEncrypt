using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPassword.View;
using ProyectoPassword.UserControl;

namespace ProyectoPassword.ViewModel
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _userName;
        [ObservableProperty]
        private string _password;
        [ICommand]
        public async void Login()
        {
            if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
            {
                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }
    }
}
