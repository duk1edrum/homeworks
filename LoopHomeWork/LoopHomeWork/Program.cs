using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту прямоугольника : ");
            int heigh = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ширину прямоуголника : ");
            int width = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < heigh; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
                
           
        }
    }
}
