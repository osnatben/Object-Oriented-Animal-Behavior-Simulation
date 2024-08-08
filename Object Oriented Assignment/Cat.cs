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
            if (Mood == MOOD_HAPPY)
            {
                Console.WriteLine("urr, purr");
            }
            else if (Mood == MOOD_SCARE)
            {
                Console.WriteLine("hiss");
            }
            else
            {
                Console.WriteLine("meow~");
            }

        }

        public override void SeyHello(int mood)
        {
            Mood = mood;
            SeyHello();
        }



    }
}
