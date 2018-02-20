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
            ColorPrint colorPrint = new ColorPrint(ConsoleColor.DarkGreen);
            colorPrint.Print("Duk1e");

            ColorPrint colorPrintUp = colorPrint;
            colorPrint.Print("Hello-");

            ColorPrint colorPrint1 = new ColorPrint(ConsoleColor.DarkRed);
            colorPrint.Print("Duk1eDrums");

        }
    }
}
