using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side1 treangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side2 treangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Perimert = {0} , Area = {1}, ",rectangle.Perimetr, rectangle.Area);

            Console.ReadKey();
        }
    }
}
