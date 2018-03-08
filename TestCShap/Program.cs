using System;

namespace TestCShap
{

    public class TestStatic
    {
        public static int Test = 1;

        public static int Test1 => Test;
    }

    class Program
    {
    
    
        static void Main(string[] args)
        {
            Console.WriteLine(TestStatic.Test);
            TestStatic testStatic = new TestStatic();
            
        }

    }
}