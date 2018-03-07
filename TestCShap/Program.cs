using System;

namespace TestCShap
{
    class Program
    {

        static int SumValues(params int[] vals)
        {
            int sum = 0;
            foreach (var val in vals)
            {
                sum += val;
            }

            return sum;
        }
        
        static void Main(string[] args)
        {
            int sum = SumValues(1, 5, 2, 9, 8);
            Console.WriteLine("Summed Values = {0}", sum);
            Console.ReadKey();
        }
    }
}