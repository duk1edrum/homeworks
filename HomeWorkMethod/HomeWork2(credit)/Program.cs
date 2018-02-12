using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  помогает определить, погасил ли клиент кредит или нет. 
///  Допустим, ежемесячная сумма платежа должна составлять 100 грн. 
///  Клиент должен выполнить 7 платежей, но может платить реже большими суммами. 
///  Т.е., может двумя платежами по 300 и 400 грн. Закрыть весь долг. 
/// Создайте метод, который будет в качестве аргумента принимать сумму платежа, 
/// введенную экономистом банка. 
/// Метод выводит на экран информацию о состоянии кредита 
/// (сумма задолженности, сумма переплаты, сообщение об отсутствии долга).  
/// </summary>
namespace HomeWork2_credit_
{
    class Program
    {
        static void OstatPOCredit(ref double plateg)
        {
            double creditBody = 700;

            if (plateg >= 700)
            {
                Console.WriteLine("Кредит погашен.Переплата составляет {0}", plateg - creditBody);
            }
            else if (plateg == 700)
            {
                Console.WriteLine("Кредит погашен.Задолжность отсутвует.");
            }
            else if (plateg >= 100)
            {
                Console.WriteLine("Задолность по кредиту состовляет {0}", creditBody - plateg);
            }
            else
            {
                Console.WriteLine("Внесенная вами сумма меньше обязательного платежа!");
                Console.WriteLine("Обязательный платеж состовляет 100!Задолжность по кредиту {0}",creditBody - plateg);
            }

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Сумма платежа: ");
            double plateg = int.Parse(Console.ReadLine());

            OstatPOCredit(ref plateg);

            Console.ReadKey();
        }
    }
}
