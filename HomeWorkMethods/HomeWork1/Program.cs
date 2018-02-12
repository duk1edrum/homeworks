using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Add(int a, int b)
        {
            int add = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, add);

        }

        static void Sub(int a, int b)
        {
            int sub = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
        }

        static void Mul(int a, int b)
        {
            int mul = a * b;
            Console.WriteLine("{0} * {1} = {2}", a, b, mul);
        }
        static void Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("На Ноль делить Нельзя, повторите пожалуйста ввод!");

            }
            else
            {
                int div = a / b;
                Console.WriteLine("{0} * {1} = {2}", a, b, div);
            }
        }



        static void Main(string[] args)
        {
            Enternumber:
            Console.Write("Введите первое число: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите знак арефитической операции +, -, *, /: ");
            string sing = Console.ReadLine();

            switch (sing)
            {
                case "+":
                    Add(operand1, operand2);
                    break;
                case "-":
                    Sub(operand1, operand2);
                    break;
                case "*":
                    Mul(operand1, operand2);
                    break;
                case "/":
                    Div(operand1, operand2);
                    goto Enternumber;
                    break;
            }
            Console.ReadKey();

        }
    }
}
