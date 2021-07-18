using System;

namespace Method
{

    //Write a method to print the smallest of three integer numbers. Use appropriate name for the method.
    class Program
    {
        static void Main()
        {

            SmallestNumber();

            static void SmallestNumber()
            {
                int smallestNum = Int32.MaxValue;

                for (int i = 0; i < 3; i++)
                {
                    int num = int.Parse(Console.ReadLine() ?? string.Empty);
                    if (num < smallestNum)
                    {
                        smallestNum = num;
                    }
                }

                Console.WriteLine(smallestNum);
            }
        }
    }
}
