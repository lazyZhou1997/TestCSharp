using System.Collections;

namespace TestCSharp
{
    public class Animals:CollectionBase
    {
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }

        public void Remove(Animal oldAnimal)
        {
            List.Remove(oldAnimal);
        }

    }
    
}