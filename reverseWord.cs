/*
 * FILE NAME: reverseWord.cs
 * PROJECT NAME: Reverse Swap Project
 * DATE INITIATLIZED: 30 July 2018
 * DESCRIPTION: A C# program designed to reverse the order of three (3) x char values
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseWord
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;

            Console.Write("\nInput the first character:");
            a = char.Parse(Console.ReadLine());

            Console.Write("\nInput the second character:");
            b = char.Parse(Console.ReadLine());

            Console.Write("\nInput the third and final character:");
            c = char.Parse(Console.ReadLine());

            Console.Write("\nBefore the swap: " + a + " " + b + " " + c);
            Console.Write("\nAfter the swap: " + c + " " + b + " " + c);
            Console.Read();
        }
    }
}
