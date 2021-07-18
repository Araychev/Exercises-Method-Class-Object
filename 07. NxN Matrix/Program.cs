using System;

namespace _07._NxN_Matrix
{
    //Write a method that receives a single integer N and prints NxN matrix with that number.

    class Program
    {
        static void Main()
        {
            PrintMatrix();

            static void PrintMatrix()
            {
                int number = int.Parse(Console.ReadLine() ?? string.Empty);


                for (int row = 0; row < number; row++)
                {
                    for (int col = 0; col < number; col++)
                    {
                        Console.Write(number + " ");
                    }

                    Console.WriteLine();
                }

            }
        }
    }
}
