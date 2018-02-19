using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClass2
{
    class User
    {
        string login, name, familyname;
        int age;
        public readonly DateTime date;

        public string Login
        {
            set { login = value; }
            get
            {
                if (login == null)
                    return "Field is empty";
                else return login;
            }
        }

        public string Name
        {
            set { name = value; }

            get
            {
                if (name == null)
                    return "Field is empty";
                else return name;
            }
        }

        public string FamilyName
        {
            set { familyname = value; }
            get
            {
                if (familyname == null)
                    return "Field is empty";
                else return familyname;
            }
        }

        public int Age
        {
            set { age = value; }
            get {
                return age;
            }
        }

        public User()
        {
            date = DateTime.Now;
        }

        public User(string login, string name, string familyname, int age, DateTime date)
        {
            this.login = login;
            this.name = name;
            this.familyname = familyname;
            this.age = age;
            this.date = DateTime.Now;
        }

    }
}
