using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    class Converter
    {
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void FromUahToUsd(double uahSum)
        {
            Console.WriteLine("uah to usd = {0}",uahSum / usd);
        }

        public void FromUsdToUah(double usdSum)
        {
            Console.WriteLine("usd to uah = {0}",usd * usdSum);
        }

        public void FromEurToUah(double uahSum)
        {
            Console.WriteLine(uahSum * eur);
        }

        public void FromUahToEur(double eurSum)
        {
            Console.WriteLine(eurSum / eur);
        }

        public void FromRubtoUah(double uahSum)
        {
            Console.WriteLine(uahSum / rub);
        }

        public void FromUahToRub(double rubSum)
        {
            Console.WriteLine(rub * rubSum);
        }
    }
}
