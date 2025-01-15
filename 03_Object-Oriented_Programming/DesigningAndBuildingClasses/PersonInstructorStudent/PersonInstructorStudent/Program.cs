using System;

namespace PersonInstructorStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Student instance
            Student student = new Student("John Doe", new DateTime(2000, 5, 15));
            student.AddAddress("123 Main St");
            student.AddAddress("456 Oak Ave");
            student.EnrollCourse("Mathematics");
            student.EnrollCourse("Computer Science");
            student.AddGrade(3.5);
            student.AddGrade(3.7);
            student.AddGrade(4.0);

            // Calculate GPA
            double gpa = student.CalculateGPA();
            Console.WriteLine($"{student.Name}'s GPA is {gpa:F2}.");

            // Display Addresses
            student.GetAddresses();

            // Calculate Age
            student.CalculateAge();

            // Calculate Salary
            decimal studentSalary = student.CalculateSalary();
            Console.WriteLine($"{student.Name}'s Salary: {studentSalary:C}");

            Console.WriteLine();

            // Create Instructor instance
            Instructor instructor = new Instructor("Dr. Jane Smith", new DateTime(1980, 8, 22), new DateTime(2010, 9, 1), 60000m);
            instructor.AddAddress("789 Pine Rd");
            instructor.AssignDepartment("Physics");
            instructor.CalculateBonus();

            // Calculate Salary
            decimal instructorSalary = instructor.CalculateSalary();
            Console.WriteLine($"{instructor.Name}'s Salary: {instructorSalary:C}");

            // Calculate Age
            instructor.CalculateAge();
        }
    }
}