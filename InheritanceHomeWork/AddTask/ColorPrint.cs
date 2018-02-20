using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomeWork
{

    class ColorPrint : Printer
    {
        public ColorPrint(ConsoleColor color)
            : base(color)
        { }
    }
}
