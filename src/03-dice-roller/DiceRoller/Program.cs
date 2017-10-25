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
            
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            DiceRoller diceRoller = new DiceRoller();
            List<DiceRoll> diceRolls = diceRoller.Roll(
                new List<Dice> { Dice.D6, Dice.D6, Dice.D6, Dice.D8, Dice.D8 });

            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"1{diceRoll.Dice}: {diceRoll.Value}");
            }

            Console.WriteLine();
            Console.WriteLine($"Roll total: { diceRolls.Sum(x => x.)}"

            /*var total = 0;

             var d6 = new Dice.D6;

             for (var i=0; i<3; i++)
             {
                 var roll = d6.Roll(6);
                 total += roll;

                 Console.WriteLine($"1d6: {roll}");
             }

             Dice d8 = new Dice.D8;
             for (var i=0; i<2; i++)
             {
                 var roll = d8.Roll(8);
                 total += roll;

                 Console.WriteLine($"{}: {roll}");
             }

             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine("Roll total: 20");
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine(">");*/
            Console.ReadLine();
        }
    }
}
