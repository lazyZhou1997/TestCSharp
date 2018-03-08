using System;

namespace TestCSharp
{
    public class Chicken : Animal
    {
        public void LayEgg()
        {
            Console.WriteLine("{0} has laid an egg", Name);
        }

        public Chicken(string newName) : base(newName)
        {
            
        }
    }
}