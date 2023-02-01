using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Views.Accessibility;
using Microsoft.Toolkit.Mvvm.Input;
using ProyectoPassword.Models;

namespace ProyectoPassword.ViewModel
{
    public partial class NewPassViewModel : BasePassViewModel
    {
        public NewPassViewModel()
        {
            PasSword= new PasSword();
        }
        [ICommand]
        public async void SavePass()
        {
            var pass = PasSword;
            await App.PassService.AddUpdatePassAsync(pass);
            await Shell.Current.GoToAsync("..");

        }
        [ICommand]
        public async void OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
