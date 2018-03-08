using System;

namespace TestCShap
{
    public interface IMyInterface
    {
        void DoSomething();
        void DoSomethingElse();
    }

    public class MyClass : IMyInterface
    {
        //显示的实现接口
        void IMyInterface.DoSomething()
        {
            
        }

        public void DoSomethingElse()
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.DoSomething();
        }
    }
}