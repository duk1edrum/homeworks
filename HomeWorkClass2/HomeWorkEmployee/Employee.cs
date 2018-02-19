using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEmployee
{
    class Employee
    {
        readonly string familyName, name;
        int exp;
        string post;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string FamilyName
        {
            get
            {
                return familyName;
            }
        }
        public string Post
        {
            get
            {
                if (post == null) { return "Вакансия не найдена"; }
                    
                return post;
            }
            set
            {
                if (value != null)
                    post = value;

            }

        }
        public int Exp
        {
            get
            {
                return exp;
            }
            set
            {
                if (exp >= 0)
                    exp = value;
            }
        }
        public Employee()
        {

        }
        
        public Employee(string familyName, string name)
        {
            this.familyName = familyName;
            this.name = name;
        }
        public double CountSalary()
        {
            double salarykoef;

            switch (post.ToLower())
            {
                case "manager":
                    salarykoef = 200;
                    break;
                case "developer":
                    salarykoef = 100;
                    break;
                case "secretary":
                    salarykoef = 50;
                    break;
                case "cleaner":
                    salarykoef = 25;
                    break;
                default:
                    salarykoef = 100;
                    break;
            }
            switch (exp)
            {
                case 0:
                    salarykoef *= 1.5;
                    break;
                case 1:
                    salarykoef *= 2;
                    break;
                case 2:
                    salarykoef *= 2.5;
                    break;
                case 3:
                    salarykoef *= 3;
                    break;
                case 4:
                    salarykoef *= 3.5;
                    break;
            }
            return salarykoef;
        }

        public void ShowSalary()
        {
            
            Console.WriteLine("Зарплата с учетом стажа = {0} , Подоходный налог 18% = {1}", CountSalary(), CountSalary() * 0.18);
        }
    }
}
