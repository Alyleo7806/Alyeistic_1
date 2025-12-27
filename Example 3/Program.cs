using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Ali Mustafa";
            student1.Age = 19;
            student1.StudentId = "2024-ag-8031";
            student1.GPA = 3.2;

            Teacher teacher1 = new Teacher();
            teacher1.Name = "Sir Zeeshan";
            teacher1.Age = 45;
            teacher1.Subject = "OOP";
            teacher1.YearsExperience = 15;

            student1.Greet();  // "Hello, my name is Ali"
            teacher1.Greet();  // "Hello, my name is Zeeshan"

            student1.Study();  // "Ali is studying hard!"
            teacher1.Teach();  // "Zeeshan is teaching OOP"

            Console.WriteLine("\nStudent Information:");
            Console.WriteLine($"Name: {student1.Name}");
            Console.WriteLine($"Age: {student1.Age}");
            Console.WriteLine($"Student ID: {student1.StudentId}");
            Console.WriteLine($"GPA: {student1.GPA}");

            Console.WriteLine("\nTeacher Information:");
            Console.WriteLine($"Name: {teacher1.Name}");
            Console.WriteLine($"Age: {teacher1.Age}");
            Console.WriteLine($"Subject: {teacher1.Subject}");
            Console.WriteLine($"Experience: {teacher1.YearsExperience} years");
        }
    }
}
