using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPassword.View;

namespace ProyectoPassword.ViewModel
{
    public partial class AppShellViewModel : BaseViewModel
    {
        [ICommand]
        async void SignOut()
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        } 
    }
}
