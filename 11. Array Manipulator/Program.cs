using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            int[] line = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case"exchange":
                        int idx = int.Parse(tokens[1]);

                        line.Append()
                        break;
                    case"max":
                        break;
                    case"min":
                        break;
                    case"first":
                        break;
                    case"last":
                        break;
                }
            }


        }
    }
}
