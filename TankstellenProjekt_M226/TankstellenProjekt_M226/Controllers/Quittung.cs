using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankstellenProjekt_M226.Controllers
{
    class Quittung
    {
        private string treibstoff;
        private string literzahl;
        private double betrag;
        private string datum;
        private string uhrzeit;

        public string Treibstoff { get; set; }
        public string Literzahl { get; set; }
        public double Betrag { get; set; }
        public string Uhrzeit { get; set; }
        public string Datum { get; set; }
    }


}
