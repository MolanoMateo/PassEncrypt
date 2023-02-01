using Microsoft.Toolkit.Mvvm.Input;
using ProyectoPassword.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPassword.ViewModel
{
    public partial class PassPageViewModel:BasePassViewModel
    {
        [ICommand]
        private async void OnAddPass()
        {
            await Shell.Current.GoToAsync(nameof(NewPassPage));
        }
    }
}
