using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment
{
    internal class Frog : Animal, ILand, IWater
    {
        public Frog(int mood) : base(false, false, mood) { }


        private readonly int NumberOfLegs = 4;

        public int GetNumberOfLegs()
        {
            return NumberOfLegs;
        }

        public override void SeyHello(int mood)
        {
            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("quack quack quack on the shore");
            }
            else if (mood == MOOD_SCARE)
            {
                Console.WriteLine("plop into the water");
            }
            
        }       

        public bool HasGills()
        {
            return false;
        }

        public bool HasLaysEggs()
        {
            return true;
        }
    }
}
