using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInClass
{
    public class Organization
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public Organization()
        {
            Name = "N/A";
            Country = "N/A";
            City = "N/A";
            Address = "N/A";
            Telephone = "N/A";
        }
        public Organization(string name, string country, string city, string address, string telephone)
        {
            Name = name;
            Country = country;
            City = city;
            Address = address;
            Telephone = telephone;
        }

        public bool Read()
        {
            Console.Write("Input name of Organization: ");
            Name = Console.ReadLine();
            if (Name == string.Empty) return false;

            Console.Write("Input country: ");
            Country = Console.ReadLine();
            if (Country == string.Empty) return false;

            Console.Write("Input city: ");
            City = Console.ReadLine();
            if (City == string.Empty) return false;

            Console.Write("Input address: ");
            Address = Console.ReadLine();
            if (Address == string.Empty) return false;

            Console.Write("Input telephone: ");
            Telephone = Console.ReadLine();
            if (Telephone.Length != 10 || !int.TryParse(Telephone, out int _)) return false;

            return true;
        }
        public void WriteDetails()
        {
            Console.WriteLine($"\n\"{Name}\" - {Address}, {City}, {Country} - {Telephone}.");
        }

        ~Organization()
        {
            Console.WriteLine("~~~~END~~~~");
        }
    }
}
