/*Write a program that reads two integer arrays from the console
and compares them element by element.*/

using System;

namespace CompareArrays
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of element of first array: ");
            int[] firstArray = new int[int.Parse(Console.ReadLine())];
            Console.Write("Enter number of element of second array: ");
            int[] secondArray = new int[int.Parse(Console.ReadLine())];

            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("The two arrays are different!(different count of elements)");
                return;
            }
            else
            {
                Console.WriteLine("Enter the elements of first array:");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write("element[{0}] = ", i);
                    firstArray[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter the elements of second array:");
                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write("element[{0}] = ", i);
                    secondArray[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("The Arrays are different!(different elements)");
                        return;
                    }
                }
            }

            Console.WriteLine("The arrays are equal.");
        }
    }
}
