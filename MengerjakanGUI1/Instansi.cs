using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MengerjakanGUI1
{
    public class Instansi
    {
        public string Nama { get; set; }
        public string Kota { get; set; }
        public string Email { get; set; }
        public string Kategori { get; set; }
        public DateOnly TglBerdiri { get; set; }
        public Boolean Status_Aktif { get; set; }
    }
}
