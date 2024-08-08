using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment
{
    public abstract class Animal
    {


        protected readonly bool Mammals;
        protected readonly bool Carnivorous;
        public const int MOOD_HAPPY = 1;
        public const int MOOD_SCARE = 2;
        protected int Mood;

        public Animal(bool mammals, bool carnivorous,int mood)
        {
            Mammals = mammals;
            Carnivorous = carnivorous;            
            Mood = mood;
        }

        public virtual void SeyHello() { }
        public abstract void SeyHello(int mood) ;

        public bool IsMammals() { return Mammals; }
        public void SetMammals(bool mammals) { }

        public bool IsCarnivorous() { return Carnivorous; } 
        public void SetCarnivorous(bool carnivorous) { }

        public void SetMood(int mood)
        {
            Mood = mood;
        }
}
