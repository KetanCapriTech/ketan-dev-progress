using FoundationC_PracticeConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance
{
    public class QuantifierOperator
    {
        public void  QuantifierOperatorEx1ALL() {

            List<Employee> employee = new List<Employee>() {
                new Employee()
                {
                    Name = "A",
                    Id = 1,
                    Salary = 50000
                },
                new Employee()
                {
                    Name = "B",
                    Id = 2,
                    Salary = 70000
                },
                new Employee()
                {
                    Name = "C",
                    Id = 3,
                    Salary = 30000
                },
                new Employee()
                {
                    Name = "D",
                    Id = 4,
                    Salary = 90000
                },
                new Employee()
                {
                    Name = "E",
                    Id = 5,
                    Salary = 25000
                }
            };

            var checkAllHasSaleryMoreThan40K = employee.All(emp => emp.Salary < 40000);

            Console.WriteLine(checkAllHasSaleryMoreThan40K);
            
        }

        public void QuantifierOperatorEx1Any()
        {

            List<Employee> employee = new List<Employee>() {
                new Employee()
                {
                    Name = "A",
                    Id = 1,
                    Salary = 50000
                },
                new Employee()
                {
                    Name = "B",
                    Id = 2,
                    Salary = 70000
                },
                new Employee()
                {
                    Name = "C",
                    Id = 3,
                    Salary = 30000
                },
                new Employee()
                {
                    Name = "D",
                    Id = 4,
                    Salary = 90000
                },
                new Employee()
                {
                    Name = "E",
                    Id = 5,
                    Salary = 25000
                }
            };

            var checkAllHasSaleryMoreThan40K = employee.Any(emp => emp.Salary < 40000);

            Console.WriteLine(checkAllHasSaleryMoreThan40K);

        }

        public void QuantifierOperatorEx2Conatins()
        {
            List<Students> students = new List<Students>() {

                new Students
                {
                   Id = 1, Name = "devid", Marks = 78
                },
                new Students
                {
                    Id = 2 , Name = "Anajaya", Marks = 99
                },
                new Students
                {
                    Id = 3 , Name = "Rehan", Marks = 69
                },
                new Students
                {
                    Id = 4, Name = "Sujata", Marks = 55
                }

            };

            var std = new Students() { Id = 4, Name = "Sujata", Marks = 55 };

            students.Add(std);

            bool isExist = students.Contains(std);
            Console.WriteLine(isExist);
        }
    }
}
