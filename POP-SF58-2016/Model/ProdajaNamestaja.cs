﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF58_2016.Model
{
    public class ProdajaNamestaja
    {
        public int ID { get; set; }
        public List<Namestaj> NamestajZaProdaju { get; set; }
        public DateTime DatumProdaje { get; set; }
        public string BrojRacuna { get; set; }
        public string Kupac { get; set; }
        public double PDV { get; set; }
        public List<DodatnaUsluga> DodatnaUsluga { get; set; }
        public double UkupnaCena { get; set; }
    }

}
