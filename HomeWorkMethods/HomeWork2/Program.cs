using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static float moneyConvert(float x, float y)
        {
            return x / y;
        }


        static void Main(string[] args)
        {
            Console.Write("Введите сумму в гривне: ");
            float griven = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введетите курс $: ");
            float exchangуRate = Convert.ToSingle(Console.ReadLine());

            float convertResult = moneyConvert(griven, exchangуRate);
            Console.WriteLine(" {0} гривен при курсе {1}  = {2:0.00} долларов",griven,exchangуRate,convertResult);


            Console.ReadKey();
        }
    }
}
