using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Honk();

            Console.WriteLine("Brand: " + myCar.brand);
            Console.WriteLine("Model: " + myCar.modelName);
        }
    }
}
