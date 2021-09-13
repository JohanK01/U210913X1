using System;
using System.Collections.Generic;

namespace ACME_cars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bsalu> Bilar = new List<Bsalu>();
            wrong:
            Console.WriteLine("X = Exit, N=Add Car, E=Edit existing Car, D=Remove Car, S=Show all cars");
            string orden = Console.ReadLine();

            switch (orden)
            {
                case "x":
                    Console.WriteLine("avsluta");
                    break;

                case "n":
                    Console.WriteLine("Märke, modell och färg");
                    
                        Bilar.Add(new Bsalu()
                        {
                            make = Console.ReadLine(),
                            modell = Console.ReadLine(),
                            color = Console.ReadLine()
                        });
                    Console.WriteLine("Bilen är inlaggd");
                    break;

                case "e":
                    Console.WriteLine("vilken bil vill du ändra på");
                    break;

                case "d":
                    Console.WriteLine("Vilken bil vill du ta bort");
                    break;

                case "s":
                    Console.WriteLine("Här är alla bilar vi har inne");
                    break;
                default:
                    Console.WriteLine("Försök igen");
                    goto wrong;

            }
            goto wrong;
            
        }
    }
}
public class Bsalu
{
    public string make;
    public string modell;
    public string color;
}


