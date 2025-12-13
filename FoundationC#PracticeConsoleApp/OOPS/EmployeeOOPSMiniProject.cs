using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.OOPS
{
    internal class EmployeeOOPSMiniProject
    {
        // EXAMPLE ABSTRACTION 
        abstract class Employee
        {
            // EXAMPLE ENCAPSULATION 
            private int id;
            private string name;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            // Abstract method
            public abstract double CalculateSalary();

            public void DisplayInfo()
            {
                Console.WriteLine($"ID: {Id}, Name: {Name}");
            }
        }

        // EXAMPLE INHERITANCE 
        class FullTimeEmployee : Employee
        {
            public double MonthlySalary;

            // EXAMPLE POLYMORPHISM 
            public override double CalculateSalary()
            {
                return MonthlySalary;
            }
        }

        class PartTimeEmployee : Employee
        {
            public int HoursWorked;
            public double HourlyRate;

            public override double CalculateSalary()
            {
                return HoursWorked * HourlyRate;
            }
        }

        //  entry method
        public void Run()
        {
            // Polymorphism
            Employee emp1 = new FullTimeEmployee()
            {
                Id = 1,
                Name = "ketan",
                MonthlySalary = 50000
            };

            Employee emp2 = new PartTimeEmployee()
            {
                Id = 2,
                Name = "shiva",
                HoursWorked = 80,
                HourlyRate = 400
            };

            emp1.DisplayInfo();
            Console.WriteLine("Salary: " + emp1.CalculateSalary());

            Console.WriteLine();

            emp2.DisplayInfo();
            Console.WriteLine("Salary: " + emp2.CalculateSalary());
        }
    }
}
