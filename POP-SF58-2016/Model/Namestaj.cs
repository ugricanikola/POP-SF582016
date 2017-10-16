﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF58_2016.Model
{
    public class Namestaj
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public double JedinicnaCena { get; set; }
        public int KolicinaUMagacinu { get; set; }

        public TipNamestaja TipNamestaja { get; set; }
        public bool Obrisan { get; set; }


    }
}
