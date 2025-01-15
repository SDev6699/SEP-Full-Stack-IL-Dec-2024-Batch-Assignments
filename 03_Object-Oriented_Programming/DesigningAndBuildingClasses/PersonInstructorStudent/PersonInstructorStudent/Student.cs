using System;
using System.Collections.Generic;

namespace PersonInstructorStudent
{
    public class Student : Person, IStudentService
    {
        // Properties
        public List<string> Courses { get; private set; } = new List<string>();
        private List<double> grades = new List<double>();

        // GPA
        public double GPA { get; private set; }

        // Constructor
        public Student(string name, DateTime birthDate) : base(name, birthDate)
        {
        }

        // Implement IStudentService methods
        public void EnrollCourse(string course)
        {
            Courses.Add(course);
            Console.WriteLine($"{Name} has enrolled in {course}.");
        }

        public double CalculateGPA()
        {
            if(grades.Count == 0)
                return 0.0;
            double sum = 0;
            foreach(var grade in grades)
                sum += grade;
            GPA = sum / grades.Count;
            return GPA;
        }

        // Implement abstract method
        public override decimal CalculateSalary()
        {
            // Students typically do not have a salary
            return 0m;
        }

        // Method to add a grade
        public void AddGrade(double grade)
        {
            if(grade < 0.0 || grade > 4.0)
                throw new ArgumentOutOfRangeException(nameof(grade), "Grade must be between 0.0 and 4.0.");
            grades.Add(grade);
        }
    }
}