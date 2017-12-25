using System;
namespace Indeksery
{
    class Program
    {
        // lista naszych nazw
        private string[] nameList = new string[size];
        // rozmiar
        static int size = 10;
        static void Main(string[] args)
        {
            Program names = new Program();
            names[0] = "Audi";
            names[1] = "Pagani";
            names[2] = "BMW";
            names[3] = "Nissan";
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
        // Konstruktor klasy powoduje wypełnienie listy elementami 'N.A'
        public Program()
        {
            for (int i = 0; i < size; i++)
            {
                nameList[i] = "N.A";
            }
        }
        // Indekser
        public string this[int index]
        {
            get
            {
                string temp;
                if (index >= 0 && index <= size - 1)
                    temp = nameList[index];
                else
                    temp = "";
                return temp;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                    nameList[index] = value;
            }
        }
    }
}
