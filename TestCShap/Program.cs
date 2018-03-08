using System;

namespace TestCShap
{

    class Parent
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("Parent");
        }
    }

    class Child:Parent
    {
        public override void DoSomething()
        {
            Console.WriteLine("Child");
            ((Parent) this).DoSomething();
        }
    }

    class Program
    {
    
    
        static void Main(string[] args)
        {
            Child child = new Child();
            //child.DoSomething();
            Parent parent = child;
            parent.DoSomething();
        }

    }
}