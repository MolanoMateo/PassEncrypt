using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPassword.Models
{
    public class PasSword
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Passw { get; set; }
        public string Extra { get; set; }
    }
}
