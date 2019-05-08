using System;
using System.Collections.Generic;
using System.Text;

namespace SplitAnArayIntoTwoHalves
{
    class ArrayUtility
    {
        public static int[] GetArrayFromUserInput() {
            int[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int numberElemts = int.Parse(Console.ReadLine().Trim());
                array = new int[numberElemts];
                Console.WriteLine("Enter the elements of the array separated " +
                    "by space, comma or semi-colon");
                String[] elements = Console.ReadLine().Trim().Split(' ',',',';');
                for (int index = 0; index < numberElemts; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return array;
        }

        public static void PrintArrayHalves(int[] array) {

            int sizeBy2 = array.Length / 2;
            //Print Second Half
            Console.WriteLine("Printing second half...");
            for (int index = sizeBy2; index < array.Length; index++) {
                Console.Write(array[index]+ " ");
            }

            Console.WriteLine();

            //Print First Half
            Console.WriteLine("Printing first half...");
            for (int index = 0; index < sizeBy2; index++)
            {
                Console.Write(array[index]+ " ");
            }
            Console.WriteLine();
        }
    }
}
