using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    class Student : Person
    {
        public string StudentId { get; set; }
        public double GPA { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying hard!");
        }
    }
}
