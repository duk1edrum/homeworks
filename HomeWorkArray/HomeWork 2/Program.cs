using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// </summary>
namespace HomeWork_2
{
    class Program
    {
        static int MaxNumber(int[] array)
        {
            int max = 0;
            //Наибольшее значение массива
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];

            }
            return max;
        }

        static int MiddleaArithemtic(int[] array)
        {
            int middle = 0;
            for (int i = 0; i < array.Length; i++)
            {
                middle += array[i];

            }

            return middle/array.Length;
        }

        static void OddNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                Console.WriteLine(array[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элеметов массива:");
            int number = int.Parse(Console.ReadLine());

            int[] array = new int[number];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1);
            }
            
            int max = MaxNumber(array);
            int middle = MiddleaArithemtic(array);

            Console.WriteLine("Максимальный элемент массива:{0} ", max);
            Console.WriteLine("Среднее арифметическое {0}",middle);
            OddNumbers(array);


            Console.ReadKey();
        }
    }
}
