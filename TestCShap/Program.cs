using System;

namespace TestCShap
{
    class Program
    {
        delegate double ProcessDelegate(double param1, double param2);

        static double Mutiply(double param1, double param2)
        {
            return param1 * param2;
        }

        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }

        static void Main(string[] args)
        {
            ProcessDelegate process;
            
            process = Mutiply;
            Console.WriteLine("乘:{0}",process(12,4));

            process = Divide;
            Console.WriteLine("除:{0}",process(12,4));

        }
    }
}