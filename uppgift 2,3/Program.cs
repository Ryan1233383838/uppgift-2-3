using System;
namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många dagar till vill du hyra efter första dagen");
            int dagar = int.Parse(Console.ReadLine());
            int Antaldagar = dagar * 500;
            int dagarsen = 300 + Antaldagar;


            Console.WriteLine("hur många kilometer vill du köra med bilen");
            int kilometer = int.Parse(Console.ReadLine());
            int Antalkilometer = 1 * kilometer;

            int summa = dagarsen + Antalkilometer;
            Console.WriteLine(" summa är " + summa );

        }
    }
}

