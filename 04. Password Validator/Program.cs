using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Password_Validator
{   

  // Write a program that checks if a given password is valid. Password rules are:
  // 6 – 10 characters (inclusive)
  // Consists only of letters and digits
  // Have at least 2 digits 
  // If a password is valid print "Password is valid". If it is not valid, for every unfulfilled rule print a message:
  // "Password must be between 6 and 10 characters"
  // "Password must consist only of letters and digits"
  // "Password must have at least 2 digits"

    class Program
    {
        static void Main()
        {

            string pass = Console.ReadLine();

            IsValid(pass);

            static void IsValid(string password)
            {
                
                if (NotValid(password) == false)
                {
                    Console.WriteLine("Password is valid");
                }
            }

            static bool NotValid(string password)
            {
                bool status = false;

                int count = 0;
                Regex regex = new Regex(@"\W");

                if (password.Length < 6 || password.Length > 10)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                    status = true;
                }
                if (!(password.All(Char.IsLetterOrDigit)))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    status = true;

                }

                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                    {
                        count++;
                    }
                }

                if (count < 2)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    status = true;

                }

                return status;
            }
        }
    }
}
