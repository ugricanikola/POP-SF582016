using POP_SF58_2016.Model;
using POP_SF58_2016.Util;
using ProstorImena;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF58_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
            Console.WriteLine("Dobrodosli u salon namestaja");
            Console.WriteLine("1 - Izlistaj sve salone");
            Console.WriteLine("2 - Dodaj novi salon");
            Console.WriteLine("3 - Izlistaj sav namestaj");
            Console.WriteLine("4 - Dodaj novi namestaj");
            Console.ReadLine();

                     var tn1 = new TipNamestaja()
                       {
                           ID = 1,
                           Naziv = "podna lampa"
                       };
                       var n1 = new Namestaj()
                       {
                           ID = 1,
                           Naziv = "socijalno osveteljenje",
                           TipNamestaja = tn1
                       };

                       var ln1 = new List<Namestaj>();
                       ln1.Add(n1);
                       GenericSerializer.Serialize<Namestaj>("namestaj.xml", ln1);

                       List<Namestaj> ucitanaLista = GenericSerializer.Deserialize<Namestaj>("namestaj.xml")
           */
            var lista = Projekat.Istance.Namestaj;
            lista.Add(new Namestaj() { ID = 28, Naziv = "Knjaz" });
            Projekat.Istance.Namestaj = lista;

            foreach (var stavka in lista)
            {
               Console.WriteLine($"{stavka.Naziv}");

            }
            Console.ReadLine();

        }
    }
}
 
