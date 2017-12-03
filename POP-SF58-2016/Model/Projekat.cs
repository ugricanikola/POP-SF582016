using POP_SF58_2016.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF58_2016.Model
{
    public class Projekat
    {
        public static Projekat Istance { get; } = new Projekat();

        private List<Namestaj> namestaj;

        public  List<Namestaj> Namestaj
        {
            get
            {
                this.namestaj = GenericSerializer.Deserialize<Namestaj>("namestaj.xml");
                return this.namestaj;
            }
            set
            {
                this.namestaj = value;
                GenericSerializer.Serialize<Namestaj>("namestaj.xml", namestaj);
            }
        }
        private List<AkcijskaProdaja> akcija;

        public List<AkcijskaProdaja> Akcija
        {
            get
            {
                this.akcija = GenericSerializer.Deserialize<AkcijskaProdaja>("akcija.xml");
                return this.akcija;
            }
            set
            {
                this.akcija = value;
                GenericSerializer.Serialize<AkcijskaProdaja>("akcija.xml,", akcija);
            }
        }
        private List<TipNamestaja> tipoviNamestaja;

        public List<TipNamestaja> TipoviNamestaja
        {
            get
            {
                this.tipoviNamestaja = GenericSerializer.Deserialize<TipNamestaja>("tipovi_namestaja.xml");
                return this.tipoviNamestaja;
            }
            set
            {
                this.tipoviNamestaja = value;
                GenericSerializer.Serialize<TipNamestaja>("tipovi_namestaja.xml", tipoviNamestaja);
            }
        }
        private List<DodatnaUsluga> dodatneUsluge;

        public List<DodatnaUsluga> DodatneUsluge
        {
            get
            {
                this.dodatneUsluge = GenericSerializer.Deserialize<DodatnaUsluga>("dodatne_usluge.xml");
                return this.dodatneUsluge;
            }
            set
            {
                this.dodatneUsluge = value;
                GenericSerializer.Serialize<DodatnaUsluga>("dodatne_usluge.xml", dodatneUsluge);
            }
        }
        

    }
}
