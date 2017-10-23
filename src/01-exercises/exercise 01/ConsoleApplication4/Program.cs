using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mina olen kalkulaatori programm. Ütle mulle 2 numbrit ja ma ütlen sulle nende summa");
            Console.WriteLine();
            Console.WriteLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine("Esimene number: " + firstNumber);
            Console.WriteLine("Teine number: " + secondNumber);
            Console.WriteLine("Summa on " + sum);
            Console.ReadLine();


        }
    }
}
