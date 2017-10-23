using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_foreach_excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] excuses = new[] { "Koer sõi kodutöö ära", "Ema ei luba arvutit kasutada", "Kass lasi peale" };

            foreach (var element in excuses)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
