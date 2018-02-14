using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("C#Via", "Rihter", "C# asdasdafgassdasdasf");

            book.Show();
            Console.ReadKey();
        }
    }
}
