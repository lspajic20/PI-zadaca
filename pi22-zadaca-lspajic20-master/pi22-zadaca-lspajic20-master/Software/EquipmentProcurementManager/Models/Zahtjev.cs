using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentProcurementManager.Models
{
    public class Zahtjev
    {
        public int idzahtjeva { get; set; } 
        public string klasa { get; set; }
        public string ubroj { get; set; }
        public DateTime datum { get; set; }
        public int idzaposlenik { get; set; }
        public string opis { get; set; }
        public string ponuditelj { get; set; }
        public float cijenaBezPDV { get; set; }
        public float cijenaSaPDV { get; set; }
        public bool ponudaodabrana { get; set; }
        public int idfinanciranje { get; set; }

       
    }
}
