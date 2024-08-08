using System;

namespace Object_Oriented_Assignment
{
    internal class TestAnimal
    {
        static void Main(string[] args)
        {
            int arraySize = 9;
            Animal[] animals = new Animal[arraySize];
            
            // A call to a function that will initialize the array
            InitializeAnimals(animals);

            // Go through an array and read the functions of each animal
            foreach (var animal in animals)
            {
                Console.WriteLine($"Hey, I'm {animal.GetType().Name}");
                animal.SeyHello();
                animal.SeyHello(Animal.MOOD_HAPPY);
                animal.SeyHello(Animal.MOOD_SCARE);

                //Mood change to scared mode
                animal.SetMood(Animal.MOOD_SCARE);
                animal.SeyHello();

                //Changing the mood to a happy state
                animal.SetMood(Animal.MOOD_HAPPY);
                animal.SeyHello();

                if (animal is ILand)
                {
                    ILand landAnimal = (ILand)animal;
                    Console.WriteLine($"Number of legs: {landAnimal.GetNumberOfLegs()}");
                }

                if (animal is IWater waterAnimal)
                {
                    Console.WriteLine($"Lays eggs: {waterAnimal.HasLaysEggs()}");
                    Console.WriteLine($"Has gills: {waterAnimal.HasGills()}");
                }
                Console.WriteLine();
            }


        }

        // A function to initialize an array
        static void InitializeAnimals(Animal[] animals)
        {
            Random random = new Random();

            for (int i = 0; i < animals.Length; i++)
            {
                int mood = random.Next(0, 3);

                if (i % 3 == 0)
                {
                    animals[i] = new Cat(mood);
                }
                else if (i % 2 == 0)
                {
                    animals[i] = new Dog(mood);
                }
                else
                {
                    animals[i] = new Frog(mood);
                }
            }
        }
    }
}
