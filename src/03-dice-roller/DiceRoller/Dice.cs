using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Dice
    {
        private static readonly Random Random { get; }

        private int Sides { get; }
        public string Description { get; }

        public Dice(int sides,String description)
        {
            this.Sides = sides;
            this.Description = description;
            this.Random = new Random();
        }

        public static Dice D6 => new Dice(6, "d6");
        public static Dice D8 => new Dice(8, "d8");


        public int Roll(int sides)
        {
           return this.Random.Next(1, this.Sides + 1);
        }
    }
}
