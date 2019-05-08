using System;

namespace SplitAnArayIntoTwoHalves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Split an array into two-halves and print them!");
            Console.WriteLine("----------------------------------------------");
            int[] array = ArrayUtility.GetArrayFromUserInput();
            ArrayUtility.PrintArrayHalves(array);
            Console.ReadLine();
        }
    }
}
