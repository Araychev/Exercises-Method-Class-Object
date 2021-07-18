using System;

namespace _6._Middle_Characters
{

   // You will receive a single string. Write a method that prints the middle character. 
   // If the length of the string is even there are two middle characters.
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            MidleChar(line);

            static void MidleChar(string line)
            {
                if (line.Length % 2 != 0)
                {
                    Console.WriteLine(line[((line.Length-1)/2)]);
                }
                else
                {
                    Console.Write(line[((line.Length)/2-1)]);
                    Console.Write(line[((line.Length)/2)]);
                }

                Console.WriteLine();
            }
        }
    }
}
