using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Имеется N клиентов, которым компания производитель должна доставить товар. 
/// Сколько существует возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина?  
///Используя Visual Studio, создайте проект по шаблону Console Application.
///Напишите программу, которая будет рассчитывать и выводить на экран количество возможных вариантов доставки товара.
///Для решения задачи, используйте факториал N!, рассчитываемый с помощью рекурсии. 
///Объясните, почему не рекомендуется использовать рекурсию для расчета факториала. 
///Укажите слабые места данного подхода.
/// </summary>
namespace FactorialRec
{
    class Program
    {
        static int Factorial(int clients)
        {

            if (clients != 0)
            {
                
                return clients * Factorial(clients-1);
            }
            else {
                return 1;
            }
        }



        static void Main(string[] args)
        {
            //Введите количество маршрутов
            Console.WriteLine("Число клиетов которым неоходима доставка: ");
            int clients = int.Parse(Console.ReadLine());

            int ways = Factorial(clients);
            Console.WriteLine("Количевсвто маршрутов: {0}", ways);

            Console.ReadKey();
        }
    }
}
