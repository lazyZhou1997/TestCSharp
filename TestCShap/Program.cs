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
            int[] myArray = {1, 8, 3, 6, 2, 5, 9, 3, 0, 2};
            int maxIndex;
            Console.WriteLine("The maximumvalue inyArray is {0}", MaxValue(myArray, out maxIndex));
            Console.WriteLine("{0}", maxIndex + 1);
        }
    }
}