using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {


            figura wynikowa = new figura();
            wynikowa.akceptujDane();
            wynikowa.wyswietl();
            //Your code goes here
            //Console.WriteLine("pole powierzchni to {0}", polepowierzchni);


        }
    }


    public class figura
    {
        //double polepowierzchni;
        double dlugosc;
        double szerokosc;

        public void akceptujDane()
        {
            dlugosc = 2;
            szerokosc = 5;
        }
        public double liczeniePola()
        {
            return dlugosc*szerokosc;

        }
        public void wyswietl()
        {
            Console.WriteLine("pole powierzchni to {0}", liczeniePola());
            Console.ReadKey();
        }
    }

   
}