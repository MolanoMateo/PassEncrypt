using ProyectoPassword.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPassword.Services.PassService
{
    public class PassService : IPassRepo
    {
        public SQLiteAsyncConnection _database;

        public PassService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<PasSword>().Wait();
        }

        public async Task<bool> AddUpdatePassAsync(PasSword passinfo)
        {
            if (passinfo.Id > 0)
            {
                await _database.UpdateAsync(passinfo);
            }
            else
            {
                await _database.InsertAsync(passinfo);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeletePassAsync(int Id)
        {
            await _database.DeleteAsync<PasSword>(Id);
            return await Task.FromResult(true);
        }

        public async Task<PasSword> GetPassAsync(int Id)
        {
            return await _database.Table<PasSword>().Where(p => p.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PasSword>> GetPassAsync()
        {
            return await Task.FromResult(await _database.Table<PasSword>().ToListAsync());
        }
    }
}
