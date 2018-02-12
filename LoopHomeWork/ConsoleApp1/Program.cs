using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите  число А : ");
            int A = Convert.ToInt32(Console.ReadLine());
            int A2 = A;
            Console.Write("Введите  число В : ");
            int B = Convert.ToInt32(Console.ReadLine());
            int B2 = B;
            int sum = B;

            //Сумма чисел в промежутке 
            if (A < B)
            {
                do
                {
                    B--;
                    sum += B;
                    

                }
                while (B >= A);
                Console.WriteLine("Cумма всех чисел в промежутке от A до B = {0}", sum);
                
            }
            else
            {
                Console.WriteLine("Число А должно быть меньше чем В !!!");

            }

            //Сумма нечетных чисел в промежутке
            int sumNechet = 0; 
            for (int i = B2; A2 <= B2; B2--)
            {
                if (B2 % 2 == 1)
                {
                    sumNechet += B2;
                }

            }
            Console.WriteLine("Сумма нечетных цифр от А до В =  {0}",sumNechet);  
            //Delay
            Console.ReadKey();
        }
    }
}
