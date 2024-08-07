using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment
{
    internal class Cat : Animal, ILand
    {
        public Cat(int mood) : base(true, true, mood) { }

        private readonly int NumberOfLegs = 4;

        public int GetNumberOfLegs()
        {
            return NumberOfLegs;
        }

        public override void SeyHello()
        {
            Console.WriteLine("meow~");
        }

        public override void SeyHello(int mood)
        {
            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("purr, purr");
            }
            else if (mood == MOOD_SCARE)
            {
                Console.WriteLine("hiss");
            }
        }

        
    }
}
