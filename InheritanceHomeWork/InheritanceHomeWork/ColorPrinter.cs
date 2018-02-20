using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomeWork
{
    class ColorPrinter : Printer
    {
        public ColorPrinter(ConsoleColor color)
            : base(color)
        { }
    }
}
