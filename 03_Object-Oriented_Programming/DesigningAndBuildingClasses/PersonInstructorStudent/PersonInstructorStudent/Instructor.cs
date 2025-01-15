using System;

namespace PersonInstructorStudent
{
    public class Instructor : Person, IInstructorService
    {
        // Properties
        public string Department { get; private set; }
        public decimal BaseSalary { get; private set; }
        public decimal Bonus { get; private set; }
        public DateTime JoinDate { get; private set; }

        // Constructor
        public Instructor(string name, DateTime birthDate, DateTime joinDate, decimal baseSalary) 
            : base(name, birthDate)
        {
            JoinDate = joinDate;
            BaseSalary = baseSalary;
            Bonus = 0m;
        }

        // Implement IInstructorService methods
        public void AssignDepartment(string department)
        {
            Department = department;
            Console.WriteLine($"{Name} has been assigned to the {Department} department.");
        }

        public void CalculateBonus()
        {
            int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
            if(DateTime.Now.DayOfYear < JoinDate.DayOfYear)
                yearsOfExperience--;
            Bonus = BaseSalary * 0.10m * yearsOfExperience; // 10% bonus per year
            Console.WriteLine($"{Name}'s bonus based on {yearsOfExperience} years of experience is {Bonus:C}.");
        }

        // Implement abstract method
        public override decimal CalculateSalary()
        {
            return BaseSalary + Bonus;
        }
    }
}