using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public delegate void Dzialanie(int x, int y);

    public class Matma
    {
        public void Dodaj(int l1, int l2) { Console.WriteLine(l1 + l2); }
        public void Odejmij(int l1, int l2) { Console.WriteLine(l1 - l2); }
    }

    class Program
    {
        static void Main()
        {
            Matma matma = new Matma();

            Dzialanie dzialanie = new Dzialanie(matma.Dodaj);

            // wywoła matma.Dodaj(5,5)
            dzialanie(5, 5);

            //dzialanie += matma.Odejmij;
            // wywoła matma.Dodaj(7,4)
            // wywoła matma.Odejmij(7,4)
            //dzialanie(7, 4);

            //dzialanie.Invoke(7, 4); // to samo co wyzej


      Console.ReadKey();
        }
    }
}
