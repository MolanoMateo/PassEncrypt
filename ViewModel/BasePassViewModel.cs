using Microsoft.Toolkit.Mvvm.ComponentModel;
using ProyectoPassword.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPassword.ViewModel
{
    public partial class BasePassViewModel : BaseViewModel
    {
        [ObservableProperty]
        private PasSword _pasSword;
    }
}
