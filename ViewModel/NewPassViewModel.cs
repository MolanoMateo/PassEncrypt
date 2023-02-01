using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
        [ICommand]
        public async void ObtenerPassword()
        {
            string url = String.Format("https://password-generator-by-api-ninjas.p.rapidapi.com/v1/passwordgenerator");
            HttpClient client=new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = new Uri("https://password-generator-by-api-ninjas.p.rapidapi.com/v1/passwordgenerator");
            
            request.Headers.Clear();
            request.Headers.Add("X-RapidAPI-Key", "a67b530775msha8abbc73a4f487dp14f78cjsn444fb1960f1a");
            request.Headers.Add("X-RapidAPI-Host", "password-generator-by-api-ninjas.p.rapidapi.com");

            var body = "";
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
            }
            var pass = PasSword;
            string Boddy = (string)body;
            string ALTPASS = Boddy.Substring(21,16);
            pass.Passw = ALTPASS;
            await App.PassService.AddUpdatePassAsync(pass);
            await Shell.Current.GoToAsync("..");
        }
        
    }
}
