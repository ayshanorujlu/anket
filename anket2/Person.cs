using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anket2
{
    public class Person
    {
        public Person() { }
        public Person(string name, string surname, string dadName, string city, string country, string phoneNumber, DateTime date, string gender)
        {
            Name = name;
            Surname = surname;
            City = city;
            Country = country;
            PhoneNumber = phoneNumber;
            Date = date;
            Gender = gender;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string DadName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public string Gender { get; set; }

    }
}
