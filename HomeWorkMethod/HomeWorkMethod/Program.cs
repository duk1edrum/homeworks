using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMethod
{
    class Program
    {
        static void Calculate(ref int a, ref int b, ref int c)
        {
            a /= 5;
            b /= 5;
            c /= 5;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int operand1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int operand2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            int operand3 = int.Parse(Console.ReadLine());

            Calculate(ref operand1, ref operand2, ref operand3);
            Console.WriteLine("Результат деление чисел на 5 : {0} {1} {2}", operand1, operand2, operand3);

            Console.ReadKey();
        }
    }
}
