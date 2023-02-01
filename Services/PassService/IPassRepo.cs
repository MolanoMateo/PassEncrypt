using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPassword.Models;

namespace ProyectoPassword.Services.PassService
{
    public interface IPassRepo
    {
        Task<bool> AddUpdatePassAsync(PasSword passinfo);
        Task<bool> DeletePassAsync(int Id);
        Task<PasSword> GetPassAsync(int Id);
        Task<IEnumerable<PasSword>> GetPassAsync();
    }
}
