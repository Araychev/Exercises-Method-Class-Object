using System;
using System.Collections.Generic;

namespace _03._Characters_in_Range
{
   // Write a method that receives two characters and prints on a single line all the characters in between them according to ASCII.

      
    class Program
    {
        static void Main()
        {
            CharBetween();

            static void CharBetween()
            {

                char one = char.Parse(Console.ReadLine() ?? string.Empty);
                char two = char.Parse(Console.ReadLine() ?? string.Empty);

                List<char> line = new List<char>();

                if (one < two)
                {
                    for (char i = one; i < two; i++)
                    {
                        line.Add(i);
                    }
                    for (char i = line[1]; i < two; i++)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine();

                }
                else
                {
                    for (char i = two; i < one; i++)
                    {
                        line.Add(i);
                    }
                    for (char i = line[1]; i < one; i++)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine();

                }
                

            }
        }
    }
}
