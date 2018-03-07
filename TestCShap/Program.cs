using System;

namespace TestCShap
{
    internal class MyBase
    {
        //Class members.
    }
    
    class Program:MyBase
    {
        public class MyClass
        {
            // Class members.
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine("reach");
        }
    }

    interface IInterface
    {
        
    }
}