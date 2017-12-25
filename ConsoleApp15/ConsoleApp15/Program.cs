using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] kolekcjaLiczb = new[] { 1, 4, 6, 5, 3, 2, 8, 9, 0 };
            //tworzymy zapytanie w którym z naszej kolekcji pobieramy wszystkie elementy
            // i wrzucamy do kolejnej kolekcji
            string[] tekstArray = new string[] { "ala", "ma", "kota", "a", "kot", "lubi", "ale" };
            //var querry1 = kolekcjaLiczb.Select(n => n).ToArray();
            var q1 = tekstArray.Select(n => n).Where(a => a.Length == 3).ToArray();
            //var querry2 = kolekcjaLiczb.Select(n => n).ToArray().OrderBy(b => b);
            // czyli dla każdego itemu znajdującego się w naszej
            // nowej kolekcji, wyświetlamy kolejne itemy

            foreach (var item in q1)
            {
                Console.Write(item + " ");
            }
            Array.Sort(q1);
            //var query2 = kolekcjaLiczb.Select(n => n).ToArray().OrderBy(b => b);
            //var query3 = kolekcjaLiczb.Select(n => n).ToArray().OrderByDescending(c => c);
            //var query4 = querry1.Select(n => n).Where(b => b <= 4).ToArray();
            //string[] tekstArray = new string[] { "ala", "ma", "kota", "a", "kot", "lubi", "ale" };
            //var q1 = tekstArray.Select(n => n).Where(a => a.Length == 3).ToArray();
       
            Console.ReadKey();
            
           /* 
            public enum Rodzaj
        {
            Osobowy, Ciezarowy
        }
        public class Pojazd
        {
            public string Marka { get; set; }
            public Rodzaj RodzajPojazdu { get; set; }
            public decimal Cena { get; set; }
            public string Kolor { get; set; }

            public Pojazd(string marka, Rodzaj rodzaj, decimal cena, string kolor)
            {
                this.Marka = marka;
                this.RodzajPojazdu = rodzaj;
                this.Cena = cena;
                this.Kolor = kolor;
            }
        } */
    }
    }
}
