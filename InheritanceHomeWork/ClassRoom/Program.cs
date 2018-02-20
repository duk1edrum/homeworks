using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new ExcelentPupil();
            Pupil p2 = new GoodPupil();
            Pupil p3 = new BadPupil();

            ClassRoom group = new ClassRoom(p1, p2, p3);
            group.Study();
            Console.WriteLine(new string('-', 40));
            //------------------------------------
            group.Read();
            Console.WriteLine(new string('-', 40));
            //-------------------------------------
            group.Write();
            Console.WriteLine(new string('-', 40));
            //-------------------------------------
            group.Relax();
            Console.WriteLine(new string('-', 40));


            Console.ReadKey();
        }
    }
}
