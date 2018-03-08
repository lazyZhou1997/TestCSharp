using System;

namespace TestCSharp
{
    public abstract class Animal:IDisposable
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            name = "The animal with no name";
        }

        public void Dispose()
        {
            Console.WriteLine("消除");
        }

        public Animal(string newName)
        {
            name = newName;
        }

        public void Feed()
        {
            Console.WriteLine("{0} has been fed.", name);
        }
    }
}