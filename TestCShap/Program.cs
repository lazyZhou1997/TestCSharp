using System;

namespace TestCShap
{
    class Program
    {
        static int MaxValue(int[] intArray, out int maxIndex)
        {
            int maxVal = intArray[0];
            maxIndex = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                {
                    maxVal = intArray[i];
                    maxIndex = i;
                }
            }

            return maxVal;
        }

        static void Main(string[] args)
        {
            int i;
            string text;
            for (i = 0; i < 10; i++)
            {
                text = "Line" + Convert.ToString(i);
                Console.WriteLine("{0}",text);
            }
            
            Console.WriteLine("Last text output in loop: {0}",text);
        }
    }
}