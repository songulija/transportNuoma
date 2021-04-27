using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportoNuoma.Classes
{
    class Apmokejimas
    {
        public int apmok_Id { get; set; }
        public char saskaitos_Nr { get; set; }
        public int apmokejimo_Suma { get; set; }
        public int graz_Nr { get; set; }
        public int nuomos_Nr { get; set; }
    }
}
