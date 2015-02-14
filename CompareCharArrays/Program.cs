/*Write a program that compares two char arrays
lexicographically (letter by letter).*/

using System;

namespace CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the elements of first array\nas sequence of characters: ");
            string first = Console.ReadLine();
            Console.Write("Enter the elements of second array\nas sequence of characters: ");
            string second = Console.ReadLine();

            if (first.Length < second.Length)
            {
                Console.WriteLine("The first array is earlier lexicographically.");
                return;
            }
            else if(first.Length > second.Length)
            {
                Console.WriteLine("The second array is earlier lexicographically.");
                return;
            }

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] < second[i])
                {
                    Console.WriteLine("The first array is earlier lexicographically.");
                    return;
                }
                else if (first[i] > second[i])
                {
                    Console.WriteLine("The second array is earlier lexicographically.");
                    return;
                }
            }

            Console.WriteLine("The arrays are equal lexicographically.");
        }
    }
}
