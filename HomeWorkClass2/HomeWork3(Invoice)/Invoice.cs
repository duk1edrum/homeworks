using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Invoice_
{
    class Invoice
    {
        int count;
        string costumer;
        string provider;

        private string article;
        private int quantity;


        public string Article { get; set; }
        public int Quantity { get; set; }

        public Invoice()
        {

        }
        public Invoice(int count, string costumer, string provider)
        {
            this.count = count;
            this.costumer = costumer;
            this.provider = provider;
        }

        public void CostCalculation(bool needNds)
        {
            double cost;

            switch (Article)
            {
                case "notepad":
                    cost = 3000;
                    break;
                case "mouse":
                    cost = 350;
                    break;
                case "iphone6plus":
                    cost = 750;
                    break;
                default:
                    Console.WriteLine("Товар не найден");
                    return;
            }
            if (needNds)
            {
                cost = cost - (cost * 0.2);
            }
           // if (needNds)
           // {
                Console.WriteLine("Cумма к оплате : {0}$", cost * Quantity);

           //}
           // else
           // {
           //     Console.WriteLine("Cумма к оплате без учета НДС : {0}$", cost * Quantity);
           //
           // }
        }
    }
}
