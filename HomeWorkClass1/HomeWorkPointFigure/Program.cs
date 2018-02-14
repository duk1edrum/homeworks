using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPointFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point("A", 3, 5), new Point("B", 4, 5), new Point("C", 5, 6));

            Console.WriteLine("Figure type = ",figure.Type);

            figure.PerimetrCalculator();

            Console.ReadKey();
        }
    }
}
