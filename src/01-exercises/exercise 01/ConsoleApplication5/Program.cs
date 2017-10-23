using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            Console.WriteLine("Ma valin välja ühe suvalise numbri [1-100]. Proovi see ära arvata :)");
            Console.Write("Sina pakud ");
            int userGuess = int.Parse(Console.ReadLine());
            Console.WriteLine("Sina pakkusid: " + userGuess);
            if (userGuess > number) {
                Console.WriteLine("Minu valitud number on väiksem");
            }
            if (userGuess < number)
            {
                Console.WriteLine("Minu valitud number on suurem");
            }
            if (userGuess == number)
            {
                Console.WriteLine("Arvasid ära!");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        }
    }
}
