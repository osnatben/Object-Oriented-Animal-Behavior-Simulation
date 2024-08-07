namespace Object_Oriented_Assignment
{
    internal class TestAnimal
    {
        static void Main(string[] args)
        {
            
            Dog dog = new Dog(1);
            Cat cat = new Cat(1);
            Frog frog = new Frog(1);

            Console.WriteLine("Dog:");
            dog.SeyHello();            
            dog.SeyHello(Dog.MOOD_HAPPY);
            dog.SeyHello(Dog.MOOD_SCARE); 
            Console.WriteLine($"Is Mammals: {dog.IsMammals()}");
            Console.WriteLine($"Is Carnivorous: {dog.IsCarnivorous()}");
            Console.WriteLine($"Number of Legs: {dog.GetNumberOfLegs()}");

            Console.WriteLine("\nCat:");
            cat.SeyHello();
            cat.SeyHello(Cat.MOOD_HAPPY);
            cat.SeyHello(Cat.MOOD_SCARE);
            Console.WriteLine($"Is Mammals: {cat.IsMammals()}");
            Console.WriteLine($"Is Carnivorous: {cat.IsCarnivorous()}");
            Console.WriteLine($"Number of Legs: {cat.GetNumberOfLegs()}");

            Console.WriteLine("\nFrog:");            
            frog.SeyHello(Frog.MOOD_HAPPY);            
            frog.SeyHello(Frog.MOOD_SCARE);
            Console.WriteLine($"Is Mammals: {frog.IsMammals()}");
            Console.WriteLine($"Is Carnivorous: {frog.IsCarnivorous()}");
            Console.WriteLine($"Number of Legs: {frog.GetNumberOfLegs()}");
            Console.WriteLine($"Has Lays Eggs: {frog.HasLaysEggs()}");
            Console.WriteLine($"Has Gills: {frog.HasGills()}");
        }
    }
}