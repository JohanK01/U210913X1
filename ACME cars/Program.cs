using System;
using System.Collections.Generic;

namespace ACME_cars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bsalu> Bilar = new List<Bsalu>();
            bool a = true;
            while (a)
            {
                Console.WriteLine("X = Exit, N=Add Car, E=Edit existing Car, D=Remove Car, S=Show all cars");
                string orden = Console.ReadLine();
                switch (orden)
                {
                    case "x": // avslutar programmet
                        Console.WriteLine("avsluta");
                        a = false;

                        break;

                    case "n": // Lägger in bilar i listan
                        Console.WriteLine("Märke, modell och färg");

                        Bilar.Add(new Bsalu()
                        {
                            make = Console.ReadLine(),
                            modell = Console.ReadLine(),
                            color = Console.ReadLine()
                            
                          
                        });
                        Console.WriteLine("Bilen är inlaggd\n");
                        break;

                    case "e": // ändrar vilken bil man vill
                        Console.WriteLine("vilken bil vill du ändra på");

                        break;

                    case "d": // vilken bil man vill ta bort
                        Console.WriteLine("Vilken bil vill du ta bort"); 
                        foreach (Bsalu b in Bilar)
                        {
                            Console.WriteLine($"{b.make} {b.modell} {b.color}");
                        }
                        int remove = Convert.ToInt32(Console.ReadLine());
                        Bilar.RemoveAt(remove -1);
                        
                        break;

                    case "s": // visar alla bilar du har laggt in
                        Console.WriteLine("Här är alla bilar vi har inne");
                        foreach (Bsalu b in Bilar)
                        {
                            Console.WriteLine($"{b.make} {b.modell} {b.color}");
                        }
                        break;
                    case "cls":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Försök igen\n");
                        break;

                }
            }


        }
    }
}
public class Bsalu
{
    public string make { get; set; }
    public string modell { get; set; }
    public string color { get; set; }

 
}


