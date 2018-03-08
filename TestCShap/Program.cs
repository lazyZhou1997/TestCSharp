using System;

namespace TestCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
        
            using (Animal animal = new Cow("哈哈"))
            {
                Console.WriteLine("1");
            }

            Console.WriteLine("2");
        }
    }
}