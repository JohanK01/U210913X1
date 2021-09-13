using System;

namespace ACME_cars
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("X = Exit, N=Add Car, E=Edit existing Car, D=Remove Car, S=Show all cars");
                string orden = Console.ReadLine();

                if (orden == "x")
                {
                    break;
                }
                if (orden == "n || N")
                {
                    Console.WriteLine("Vilken modell");
                }
                if (orden == "e || E")
                {
                    Console.WriteLine("Vilken bil vill du ändra");
                }
                if (orden == "d || D")
                {
                    Console.WriteLine("Vilken bil vill du ta bort");
                }
                if (orden == " s ||S")
                {
                    Console.WriteLine("Visa alla bilar");
                }
            }

        }
    }

    public class Bsalu
    {



    }
}
