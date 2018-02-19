using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Invoice_
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(65536, "Antonov", "Eldorado")
            {
                Article = "notepad",
                Quantity = 10,
            };
            invoice.CostCalculation(false);
            invoice.CostCalculation(true);
            
            Console.ReadKey();
        }
    }
}
