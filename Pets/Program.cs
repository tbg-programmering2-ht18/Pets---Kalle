using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static List<Animal> animals = new List<Animal>();
        private static readonly Random getrandom = new Random();

        static void Main(string[] args)
        {
            animals.Add(new Cat("Bex"));
            animals.Add(new Dog("Ivy"));
            animals.Add(new Bird("claus"));

            Console.WriteLine(@"random animal generator with genes
            Press any key to see what you are! (q. ends it all)");


            ConsoleKey ck = Console.ReadKey().Key;
            while (ck != ConsoleKey.Q)
            {
                int x = getrandom.Next(0, animals.Count - 1);
                Console.WriteLine("\nYour spirit animal is...");
                Console.WriteLine(animals[x].Show());
                Console.WriteLine("Press ESC to quit or any key to : \n");
                ck = Console.ReadKey().Key;

            }
        }
    }
}