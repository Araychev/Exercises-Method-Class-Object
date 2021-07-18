using System;

namespace _02._Vowels_Count
{       
   // Write a method that receives a single string and prints the count of the vowels. Use appropriate name for the method.
    class Program
    {
        static void Main()
        {
            VowelsCount();


            static void VowelsCount()
            {
                string word = Console.ReadLine();

                int count = 0;

                if (word != null)
                    foreach (var item in word)
                    {
                        if (item.ToString().ToLower() == "a"
                            || item.ToString().ToLower() == "e"
                            || item.ToString().ToLower() == "i"
                            || item.ToString().ToLower() == "u"
                            || item.ToString().ToLower() == "y"
                            || item.ToString().ToLower() == "o")
                        {
                            count++;
                        }
                    }

                Console.WriteLine(count);
            }
        }
    }
}


