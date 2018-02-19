using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClass2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("admin","Vitalli","Antonov",25,DateTime.Now);
            Console.WriteLine(user.date);
            Console.WriteLine(user.Login);
            Console.WriteLine(user.FamilyName);
            

            Console.ReadKey();
        }
    }
}
