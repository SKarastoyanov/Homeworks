/*Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.*/

using System;

namespace MaximalKSum
{
    class Program
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
           
            int k = int.MaxValue;
            while (k > n || k <= 0)
            {
                Console.Write("(K <= N) K = ");
                k = int.Parse(Console.ReadLine());
            }
            

            Console.WriteLine("Fill an array, contains {0} elements: ", n);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("element [{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = 0;
            Array.Sort(arr, (a, b) => b.CompareTo(a));
            for (int i = 0; i < k; i++)
            {
                maxSum += arr[i];
            }

            Console.WriteLine("Max K SUM = {0}", maxSum);
        }
    }
}
