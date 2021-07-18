using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
  // Write a program that receives a count of students - n and orders them by grade in descending order. Each student should have a First name (string), a Last name (string) and a grade (a floating-point number). 
  // Input
  // On the first line, you are going to receive n - the count of students
  // On the next n lines, you will be receiving the info about the students in the following format: 
  // "{first name} {second name} {grade}"
  // Output
  // Print each student in the following format: "{first name} {second name}: {grade}"

    class Program
    {
        static void Main()
        {
            int numOfStudents = int.Parse(Console.ReadLine() ?? string.Empty);

            List<Student> students = new List<Student>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] line = Console.ReadLine()?.Split();
                if (line != null)
                {
                    Student stud = new Student(line[0], line[1], double.Parse(line[2]));
                    students.Add(stud);
                }
            }

            List<Student> orderStudents = students.OrderByDescending(s => s.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, orderStudents));
        }
    }

}
