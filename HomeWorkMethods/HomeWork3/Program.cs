using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static string PozitivOrNegative(int x)
        {
            if (x > 0)
            {
                return "Число положительное";
            }
            else if (x == 0)
            {
                return "Нулевое число";
            }
            else
                return "Число отрицательное.";
        }

        //Определаяем простое ли число - число делиться только само на себя и на еденицу.
        static bool CheckSimpleOrNot(int x)
        {
            if (x < 2)
            {
                return false;
            }
            for (int i = 2; i < Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void divisione(int x)
        {
            int[] mas1 = new int[] { 2, 5, 3, 6, 9 };
            for (int i = 0; i < mas1.Length; i++)
            {
                if (x % mas1[i] == 0)
                {
                    Console.WriteLine("Число {0} делится без остатка {1}", x, mas1[i]);
                }
                else
                {
                    Console.WriteLine("Число {0} не делится без остатка {1}", x, mas1[i]);
                }
            }

        }




        static void Main(string[] args)
        {
            //Ввод числа и пребразование числа в строку
            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            //Использование метода проверки на  положительное или отрицательное число
            string pozitiv = PozitivOrNegative(number);
            Console.WriteLine(pozitiv);

            //Использование метода проверки на простоу числа методом перебора
            bool chekedSimple = CheckSimpleOrNot(number);
            if (chekedSimple == true)
            {
                Console.WriteLine("Число не простое ");
            }
            else
            {
                Console.WriteLine("Число сложное. ");
            }

            //Проверка на кратность 2, 5 , 3, 6, 9 без остатка
            divisione(number);

            Console.ReadKey();

        }
    }
}
