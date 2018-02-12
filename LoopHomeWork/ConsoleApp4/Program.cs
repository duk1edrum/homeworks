using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количевство клиентов которым нужно доставить товар:");
            int wayOfDelivery = Convert.ToInt32(Console.ReadLine());
            int counter = 1;

            
            //n! = n * (n - 1) * (n - 2) * ...* 1
            // !5 = 5 * (5 -1) * (5 -2 )
            do
            {
                counter *= wayOfDelivery--; 

                
            }
            while (wayOfDelivery > 0);
            Console.WriteLine("Возмодных вариантов доставки : {0:###,###,###,###,###,}", counter);

            Console.ReadKey();
        }
    }
}
