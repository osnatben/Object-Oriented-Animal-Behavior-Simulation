namespace Object_Oriented_Assignment
{
    internal class TestAnimal
    {
        static void Main(string[] args)
        {
            int arraySize = 3;
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
            for (int i = 0; i < animals.Length; i++)
            {

                if (i % 3 == 0)
                {
                    animals[i] = new Cat(Animal.MOOD_HAPPY);
                }
                else if (i % 2 == 0)
                {
                    animals[i] = new Dog(Animal.MOOD_SCARE);
                }
                else
                {
                    animals[i] = new Frog(Animal.MOOD_HAPPY);
                }
            }
        }
    }
}
