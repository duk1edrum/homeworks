using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSubArray
{
    class Program
    {
        static int[] MyReverse(int[] array)
        {
            int index = 1;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (index <= array.Length - index)
                {
                    counter = array[array.Length - index];
                    array[array.Length - index] = array[i];
                    array[i] = counter;
                    index++;
                }


            }
            return array;
        }

        static int[] Subarray(int[] array, int index, int count)
        {
            int[] array1 = new int[count];
            int k = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (index < array.Length)
                {
                    array1[k] = array[index];
                }
                else
                {
                    array1[k] = 1;
                }
                k++;
                index++;
            }
            return array1;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество элеметов массива:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("C какого элемента получить выборку?:");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("какое количесвто элементов вывети:");
            int count = int.Parse(Console.ReadLine());

            int[] array = new int[number];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] = (i + 1));
            }

            //Console.WriteLine("Реверс массива");

            //int[] reverse = MyReverse(array);
            //for (int i = 0; i < reverse.Length; i++)
            //{
            //    Console.WriteLine(reverse[i]);
            //}
            //
            int[] array1 = Subarray(array, index, count);
            Console.ReadKey();
        }
    }
}
