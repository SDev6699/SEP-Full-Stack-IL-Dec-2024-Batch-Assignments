using System;
using System.Collections.Generic;

namespace PersonInstructorStudent
{
    public abstract class Person
    {
        // Properties
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        // Addresses
        private List<string> addresses = new List<string>();

        // Constructor
        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        // Methods
        public void AddAddress(string address)
        {
            addresses.Add(address);
        }

        public void GetAddresses()
        {
            Console.WriteLine($"Addresses of {Name}:");
            foreach(var addr in addresses)
            {
                Console.WriteLine($"- {addr}");
            }
        }

        // Abstract method to calculate salary
        public abstract decimal CalculateSalary();

        // Method to calculate age
        public void CalculateAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if(DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                age--;
            Console.WriteLine($"{Name} is {age} years old.");
        }
    }
}