using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClass1
{
    class Address
    {
        private string index;
        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        private string counrty;
        public string Country
        {
            get { return counrty; }
            set { counrty = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private string house;
        public string House
        {
            get { return house; }
            set { house = value; }
        }

        private string apartment;
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.Index = "12345";
            address.Country = "Ukraine";
            address.City = "Kuiv";
            address.Street = "Khreshtuk";
            address.House = "6";
            address.Apartment = "25";

            Console.WriteLine(address.Index);
            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);

        }
    }
}
