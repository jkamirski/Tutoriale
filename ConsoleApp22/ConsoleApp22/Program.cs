using System;
using System.Text;

namespace delegatesTest
{
     delegate void CustDeleg(string t);

     class TekstyKlasa
    {
        
         static void Slowa(string a)
        {
            System.Console.WriteLine("jake a{0}",a);
            Console.ReadKey();
        }
         static void Slowa2(string b)
        {
            Console.WriteLine("jakes b{0}",b);
            Console.ReadKey();
        }
    
   
    
        static void Main(string[] args)
        {
            CustDeleg slowadel, slowadel2;
            slowadel = Slowa;
            slowadel2 = Slowa2;

            slowadel("ZZZZ");
            slowadel2("aaaaaa");

        }

    }
}