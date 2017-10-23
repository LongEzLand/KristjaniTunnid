using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] excuses = new[] { "Koer sõi kodutöö ära", "Ema ei luba arvutit kasutada", "Kass lasi peale" };
            
            for (int i = 0; i < excuses.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {excuses[i]}");
            }
            Console.ReadLine();
        }
    }
}
