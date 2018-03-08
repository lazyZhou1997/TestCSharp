using System;

namespace TestCShap
{
    public class Parent
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("Parent");
        }
    }

    public class Child : Parent
    {
        public sealed override void DoSomething()
        {
            Console.WriteLine("Child");
        }
    }

    public class GrandChild : Child
    {
        public new void DoSomething()
        {
            Console.WriteLine("GrandChild");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new GrandChild();
            parent.DoSomething();
        }
    }
}