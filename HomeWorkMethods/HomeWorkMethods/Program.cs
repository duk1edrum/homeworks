using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMethods
{
    class Program
    {
        static int Calculate(int x, int y, int z)
        {
            return (x + y + z) / 3;
        }

        static void Main(string[] args)
        {
            Console.Write("Ведите 1e число :");
            int operand1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ведите 2e число :");
            int operand2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ведите 3e число :");
            int operand3 = Convert.ToInt32(Console.ReadLine());

            int average = Calculate(operand1, operand2, operand3);

            Console.WriteLine("Среднее арифметичекое {0}, {1}, {2} = {3}", operand1, operand2, operand3, average);

            Console.ReadKey();
        }
    }
}
