using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class Generyki
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T = temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'A';
            d = 'B';
            Console.WriteLine("a= {0}, b= {1}", a, b);
            Swap(ref a, ref b);

         
        }
    }
}
