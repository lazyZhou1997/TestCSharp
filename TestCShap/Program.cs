using System;

namespace TestCShap
{
    class Program
    {

        static void ShowDouble(ref int val)
        {
            val *= 2;
            Console.WriteLine("Val doubled = {0}",val);
        }
        
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine("myNumber = {0}",number);
            ShowDouble(ref number);
            Console.WriteLine("myNumber = {0}",number);
        }
    }
}