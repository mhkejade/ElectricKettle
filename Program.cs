using System;
using System.Threading;

namespace EletricKettle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...\n");
            Thread.Sleep(1000);

            Kettle.Instance.Fill();
            Thread.Sleep(1000);

            Kettle.Instance.Boil();
            Thread.Sleep(1000);

            Kettle.Instance.Drain();
            Thread.Sleep(1000);

            Console.ReadLine();
        }
    }
}
