﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment
{
    public class Dog : Animal, ILand
    {
        public Dog(int mood) : base(true, true, mood) { }

        private readonly int NumberOfLegs = 4;

        public int GetNumberOfLegs()
        {
            return NumberOfLegs;
        }

        public override void SeyHello()
        {
            if (Mood == MOOD_HAPPY)
            {
                Console.WriteLine("bark loudly");
            }
            else if (Mood == MOOD_SCARE)
            {
                Console.WriteLine("whooping");
            }
            else
            {
                Console.WriteLine("wagging their tails");
            }
            
        }

        public override void SeyHello(int mood)
        {
            Mood = mood;
            SeyHello();
        }



        
        


    }
}
