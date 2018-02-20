using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorPrinter printer = new ColorPrinter(ConsoleColor.Blue);
            printer.Print("Hello");

            Printer printerUp = printer;
            printerUp.Print("Duk1e");

            ColorPrinter printer1 = new ColorPrinter(ConsoleColor.DarkGray);
            printer1.Print("Hello duk1e");

            Console.ReadKey();
        }
    }
}
