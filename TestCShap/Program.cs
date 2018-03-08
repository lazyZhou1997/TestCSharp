using System;

namespace TestCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using custom collection calss Animals:");
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Sarash"));
            foreach (Animal myAnimal in animalCollection)
            {
                Console.WriteLine("New {0} object added to custom collection," +
                                  "Name = {1}",myAnimal.ToString(),myAnimal.Name);
            }
        }
    }
}