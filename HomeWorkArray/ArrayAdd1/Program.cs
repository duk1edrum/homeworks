using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAdd1
{
    class Program
    {
        static int[] ArraySubstackt(int[] array)
        {
            //int k = array.Length + 1;
            int[] array1 = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[i];
                array1[array1.Length - 1] = 0;
            }
            return array1;
        }

        static int[] ArrayNew(int[] array, int value)
        {
            int[] newarray = new int [array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                if( i == 0)
                {
                    newarray[i] = value;
                }
                newarray[i + 1] = array[i];
            }
            return newarray;
        }

        static void PrintNewArray(int[] newarray)
        {
            for (int i = 0; i < newarray.Length; i++)
            {
                Console.Write("{0} ",newarray[i]);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элеметов массива:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите передаваемое значение в массив");
            int value = int.Parse(Console.ReadLine());

            int[] array = new int[number];
            //Иницализируем массив
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i] = (i + 1));
            }
            Console.WriteLine();

            int[] array1 = ArraySubstackt(array);
            //Печать массива новой длинны
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("{0} ", array1[i]);
            }
            Console.WriteLine();

            int[] newarray = ArrayNew(array,value);
            PrintNewArray(newarray);
            Console.ReadKey();
        }
    }
}
