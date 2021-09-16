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
                        Console.WriteLine("Ending");
                        a = false;

                        break;

                    case "n": // Lägger in bilar i listan
                        Console.WriteLine("Make, modell, color and registration");

                        Bilar.Add(new Bsalu()
                        {
                            make = Console.ReadLine(),
                            modell = Console.ReadLine(),
                            color = Console.ReadLine()
                        });


                        Console.WriteLine("The car is added\n");
                        break;

                    case "e": // ändrar vilken bil man vill
                        Console.WriteLine("What car do you want to edit");
                        foreach (Bsalu b in Bilar)
                        {
                            Console.WriteLine($"{b.make} {b.modell} {b.color} ");

                        }
                        int EditList = Convert.ToInt32(Console.ReadLine());
                       
                        Console.WriteLine("What do you wanna change?");
                        string EditWhat = Console.ReadLine();
                        switch (EditWhat)
                        {
                            case "make":

                                Console.WriteLine("What make is it?\n");

                                Bilar[EditList - 1].make = Console.ReadLine();

                                break;

                            case "modell":
                                Console.WriteLine("What modell is it?\n");

                                Bilar[EditList - 1].modell = Console.ReadLine();
                                break;

                            case "color":
                                Console.WriteLine("What color is it?");

                                Bilar[EditList - 1].color = Console.ReadLine();
                                break;


                            default:
                                Console.WriteLine("You must choose a make, modell or color");
                                break;
                        }


                        break;

                    case "d": // vilken bil man vill ta bort
                        Console.WriteLine("What car do you want to delete");
                        foreach (Bsalu b in Bilar)
                        {
                            Console.WriteLine($"{b.make} {b.modell} {b.color}");
                        }
                        int remove = Convert.ToInt32(Console.ReadLine());
                        Bilar.RemoveAt(remove - 1);
                        Console.WriteLine("The car is deleted\n");
                        break;

                    case "s": // visar alla bilar du har laggt in
                        Console.WriteLine("Here are all avalible cars");
                        Console.WriteLine("===============================");
                        Console.WriteLine($"{Bilar.Count}");
                        foreach (Bsalu b in Bilar)
                        {
                            Console.WriteLine($"{b.make} {b.modell} {b.color}");
                        }
                        Console.WriteLine("\n");
                        break;
                    case "cls":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Try again\n");
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