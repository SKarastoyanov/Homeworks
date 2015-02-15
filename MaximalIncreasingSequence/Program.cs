/*Write a program that finds the maximal increasing sequence in an array.*/

using System;

namespace MaximalIncreasingSequence
{
    class Program
    {
        static void Main()
        {
            char[] separators = { ' ', ',' };
            Console.Write("Enter a sequence of characters: ");
            string[] sequence = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string temp = string.Empty;
            string longestSeq = string.Empty;
            
            for (int i = 0; i < sequence.Length; i++)
            {
                if (i < sequence.Length -1 && int.Parse(sequence[i]) < int.Parse(sequence[i+1]))
                {
                    if (temp.Length == 0)
                    {
                        temp = sequence[i].ToString() + ", " +sequence[i + 1];
                    }
                    else
                    {
                        temp += ", " + sequence[i + 1];
                    }
                }
                else
                {
                    if (temp.Length > longestSeq.Length)
                    {
                        longestSeq = temp;
                    }

                    temp = string.Empty;
                }
            }

            Console.WriteLine("\b --> {0} / ({1})", longestSeq, longestSeq.Length/2);
        }
    }
}
