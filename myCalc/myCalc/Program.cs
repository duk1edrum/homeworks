using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calc
            Console.WriteLine("Введите числа с которыми необходимо сдлеать арифметические операции: ");
            Console.Write("Пожалуйста, введите первое число: ");

            // Принимаем ввод от пользователя.
            string operand1 = Console.ReadLine();

            Console.Write("Пожалуйста, второе число: ");
            string operand2 = Console.ReadLine();

            Console.Write("Введите знак арифметической операции +, -, *, /, % :");
            string sing = Console.ReadLine();

            Double operant1 = Convert.ToDouble(operand1);
            Double operant2 = Convert.ToDouble(operand2);
            Double result = 0;
            // Если оператор case имеет в своем теле код, то не поддерживается "проваливание".
            // Для организации "проваливания" можно использовать оператор безусловного перехода - goto
            switch (sing)
            {
                case "+":
                    result = operant1 + operant2;
                    Console.WriteLine("Сумма  =  {0}",result);
                    Console.ReadKey();
                    break;
                case "-":
                    result = operant1 - operant2;
                    Console.WriteLine("Вычитание  =  {0}", result);
                    Console.ReadKey();
                    break;
                case "*":
                    result = operant1 * operant2;
                    Console.WriteLine("Умножение  =  {0}", result);
                    Console.ReadKey();
                    break;
                case "/":
                    if (operant2 == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя, ввод запрещен");
                        break;
                    }
                    else
                    {
                        result = operant1 / operant2;
                        Console.WriteLine("Деление  =  {0}", result);
                        Console.ReadKey();
                    }
                    break;
                case "%":
                    result = operant1 % operant2;
                    Console.WriteLine("Остаток от деления  =  {0}", result);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуста выберите 1, 2, или 3.");
                    break;
            
             
            }
        }
    }
}


