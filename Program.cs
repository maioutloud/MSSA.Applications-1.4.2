using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Applications_1._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Class

            Student stu1 = new Student();
            try
            {
                Console.Write("Enter the Student ID : ");
                stu1.StudentId = int.Parse(Console.ReadLine());
                Console.Write("Enter the Student First Name : ");
                stu1.StudentFname = (Console.ReadLine());
                Console.Write("Enter the Student Last Name : ");
                stu1.StudentLname = (Console.ReadLine());
                Console.Write("Enter the Student Grade : (A,B,C,D,F)");
                stu1.StudentGrade = char.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter valid data.");
            }
            // Display Entry
            Console.WriteLine();
            Console.WriteLine("Student Information");
            Console.WriteLine($"Student ID: {stu1.StudentId}");
            Console.WriteLine($"Student First Name: {stu1.StudentFname}");
            Console.WriteLine($"Student Last Name: {stu1.StudentLname}");
            Console.WriteLine($"Student Grade: {stu1.StudentGrade}");
            Console.ReadKey();
            
        }
    }
}
