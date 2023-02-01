using Microsoft.Toolkit.Mvvm.Input;
using ProyectoPassword.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPassword.Models;

namespace ProyectoPassword.ViewModel
{
    public partial class PassPageViewModel:BasePassViewModel
    {
        public ObservableCollection<PasSword> PassList { get; }
        public PassPageViewModel()
        {
            PassList = new ObservableCollection<PasSword>();
            
        }
        

        [ICommand]
        private async void OnAddPass()
        {
            await Shell.Current.GoToAsync(nameof(NewPassPage));
        }
        public void OnAppearing()
        {
            IsBusy = true;
        }
        [ICommand]
        private async Task LoadPass()
        {
            IsBusy = true;
            try
            {
                PassList.Clear();
                var pasList = await App.PassService.GetPassAsync();
                foreach(var item in pasList)
                {
                    PassList.Add(item);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }
        [ICommand]
        private async void PassDelete(PasSword passinfo)
        {
            if(passinfo == null)
                return;
            await App.PassService.DeletePassAsync(passinfo.Id);
            await LoadPass();
            OnAppearing();
        }

    }
}
