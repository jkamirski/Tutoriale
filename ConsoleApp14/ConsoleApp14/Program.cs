using System;
using System.Threading;
namespace MultiThreadingCreate
{
    class Program
    {
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Wątek pochodny wystartował");
                for (int i = 0; i < 10; i++) 
                {
                    Thread.Sleep(250);
                    Console.WriteLine(i);
                }
                Console.WriteLine("Watek zostal wykonany");
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Wyjątek: ThreadAbortException");
            }
            finally
            {
                Console.WriteLine("Nie można złapać wyjątku");
            }
        
        }
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(CallToChildThread);
            Console.WriteLine("główny wątek tworzenie pochdnego");
            Thread pochodnyWatek = new Thread(ts);
            pochodnyWatek.Start();
            Thread.Sleep(2000);
            Console.WriteLine("Główny wątek: przerwanie wątku pochodnego");
            pochodnyWatek.Abort();
            Console.ReadKey();
        }
    }
}