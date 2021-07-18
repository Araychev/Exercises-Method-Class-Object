using System;

namespace _05._Add_and_Subtract
{
   //You will receive 3 integers. Write a method Sum to get the sum of the first two integers and
   //Subtract method that subtracts the third integer from the result from the Sum method
    class Program
    {
        static void Main()
        {
            int one = int.Parse(Console.ReadLine() ?? string.Empty);
            int two = int.Parse(Console.ReadLine() ?? string.Empty);
            int three = int.Parse(Console.ReadLine() ?? string.Empty);


            
            Console.WriteLine(Subtract(Sum(one,two),three));


            static int Sum(int one, int two)
            {
                int result = one + two;

                return result;
            }

            static int Subtract(int result, int three)
            {
                int subtract = result - three;

                return subtract;
            }
        }
    }
}
