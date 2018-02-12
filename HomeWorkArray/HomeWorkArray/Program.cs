using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            //Инициализация массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = array.Length-1; i >= 0 ; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
