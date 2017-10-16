using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF58_2016.Model
{
    public class AkcijskaProdaja
    {
        public int ID { get; set; }
        public DateTime DatumPocetkaAkcije { get; set; }
        public DateTime DatumZavrsetkaAkcije { get; set; }
        public bool Obrisan { get; set; }
    }
}
