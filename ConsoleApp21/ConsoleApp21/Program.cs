using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp21
{
    class KlasaMetody
    {

        public void intMetoda(int a, int b)
        {
            Console.WriteLine("suma dwoch :" +a+b);

        }
        public void intMetoda(string str1, string str2)
        {
            Console.WriteLine("suma dwoch stringi :"+str1 + str2);
        }

    }
        

    class Program
    {
        

        static void Main(string[] args)
        {
            KlasaMetody klasaMetody = new KlasaMetody();
            //klasaMetody.intMetoda(10, 20);
           klasaMetody.intMetoda("Igor", "Julka");
            Console.ReadLine();
        }
    }
}
