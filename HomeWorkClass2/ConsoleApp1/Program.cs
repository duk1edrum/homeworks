using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(26.66, 33.15, 2.05);

            converter.FromUahToUsd(100);
            converter.FromUahToEur(100);
            converter.FromUahToRub(100);

            converter.FromUsdToUah(100);
            converter.FromEurToUah(100);
            converter.FromRubtoUah(100);

            Console.ReadKey();
        }
    }
}
