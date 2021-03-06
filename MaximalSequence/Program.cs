﻿/*Write a program that finds the maximal sequence of equal elements in an array.*/

using System;

namespace MaximalSequence
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
                if (i < sequence.Length -1 && sequence[i] == sequence[i+1])
                {
                    if (temp.Length == 0)
                    {
                        temp = sequence[i].ToString() + ", " + sequence[i + 1];
                    }
                    else
                    {
                        temp +=", " + sequence[i + 1];
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
