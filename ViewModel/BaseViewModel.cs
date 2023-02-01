using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace ProyectoPassword.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        public bool _isBusy;
        [ObservableProperty]
        public string _title;
    }
}
