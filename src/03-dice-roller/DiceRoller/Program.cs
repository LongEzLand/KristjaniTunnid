using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnGenD6 = new Random().Next(1, 6);
            var rnGenD8 = new Random().Next(1, 8);

            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1d6: " + rnGenD6);
            Console.WriteLine("1d6: " + rnGenD6);
            Console.WriteLine("1d6: " + rnGenD6);
            Console.WriteLine("1d8: " + rnGenD8);
            Console.WriteLine("1d6: " + rnGenD8);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Roll total: 20");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(">");
            Console.ReadLine();
        }
    }
}
