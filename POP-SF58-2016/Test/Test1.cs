﻿using ProstorImena;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF58_2016.Test
{
    class Test1
    {
        public Test1()
        {
            A a = new A();
            a.SetNaziv("naziv svih naziva");
            Console.WriteLine("Naziv je :" + a.GetNaziv());

            a.Ime = "ime svih imena";
            Console.WriteLine("Ime je: " + a.Ime);
            Console.ReadLine();

        }
    }
}
