using FoundationC_PracticeConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance
{
    public class SortingMethodsExample
    {
        public void OrderByExample1()
        {
            List<int> numbers = new List<int>() { 3, 7, 34, 1, 77, 489, 6, 8, 9, 1, 22, 78, 343 };

            var sorted = numbers.OrderBy(x => x).ToList();

            foreach(var item in sorted)
            {
                Console.WriteLine(item);
            }
        }

        public void OrderByExample2String() {

            List<string> names = new List<string>() { "rakesh", "david" , "arnav" , "sujal" , "zakir", "aktar" ,"aashish"};

            var sortedNames = names.OrderBy(name => name).ToList();

            foreach (var item in sortedNames)
            {
                Console.WriteLine(item);
            }
        }

        public void OrderByExample3String()
        {

            List<string> names = new List<string>() { "ra1kesh", "david", "2arnav", "s2ujal", "za2kir", "1aktar", "7aashish" };

            var sortedNames = names.OrderBy(name => name).ToList();

            foreach (var item in sortedNames)
            {
                Console.WriteLine(item);
            }
        }

        public void OrderByExample2()
        {
            List<int> age = new List<int>() { 10, 14, 26, 38, 58, 6, 49, 88, 31 };

            var young = age.Where(person => person > 15 && person < 35).OrderBy(person => person).ToList();

            foreach (var youngest in young)
            {
                Console.WriteLine(youngest);
            }
        }

        public void OrderByDecendingExample1()
        {
            List<int> numbers = new List<int>() { 3, 7, 34, 1, 77, 489, 6, 8, 9, 1, 22, 78, 343 };

            var sorted = numbers.OrderByDescending(x => x).ToList();

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }

        public void OrderByDecendingExample2String()
        {

            List<string> names = new List<string>() { "rakesh", "david", "arnav", "sujal", "zakir", "aktar", "aashish" };

            var sortedNames = names.OrderByDescending(name => name).ToList();

            foreach (var item in sortedNames)
            {
                Console.WriteLine(item);
            }
        }

        public void OrderByDecendingExample3String()
        {

            List<string> names = new List<string>() { "ra1kesh", "david", "2arnav", "s2ujal", "za2kir", "1aktar", "7aashish" };

            var sortedNames = names.OrderByDescending(name => name).ToList();

            foreach (var item in sortedNames)
            {
                Console.WriteLine(item);
            }
        }

        public void OrderByDecendingExample2()
        {
            List<int> age = new List<int>() { 10, 14, 26, 38, 58, 6, 49, 88, 31 };

            var young = age.Where(person => person > 15 && person < 35).OrderByDescending(person => person).ToList();

            foreach (var youngest in young)
            {
                Console.WriteLine(youngest);
            }
        }

        public void ThenByExample1()
        {

            List<Employee> employees =
                new List<Employee>
                {
                    new Employee
                    {
                        Id = 1,
                        Name = "Test",
                        LastName = "Kvfunde",
                        Email = "Test@gmail.com",
                    },
                    new Employee
                    {
                        Id = 2,
                        Name = "andy",
                        LastName = "jackson",
                        Email = "AJ@gmail.com"
                    },
                    new Employee
                    {
                        Id = 3,
                        Name = "Zakir",
                        LastName = "Shrivastav",
                        Email = "maharajmaolana@gmail.com"
                    },
                    new Employee {
                        Id = 4,
                        Name = "husain",
                        LastName = "Jibana",
                        Email = "jibana@gmail.com"
                    }
                };


            var sort = employees.OrderBy(e => e.Name ).ThenBy(e => e.LastName).ToList();

            foreach (var sortedEmployee in sort) {
                Console.WriteLine(sortedEmployee.Id + " " + sortedEmployee.Name + " " + sortedEmployee.LastName);
            }
        }
        public void ThenByDesendingExample1()
        {

            List<Employee> employees =
                new List<Employee>
                {
                    new Employee
                    {
                        Id = 1,
                        Name = "Test",
                        LastName = "Kvfunde",
                        Email = "Test@gmail.com",
                    },
                    new Employee
                    {
                        Id = 2,
                        Name = "andy",
                        LastName = "jackson",
                        Email = "AJ@gmail.com"
                    },
                    new Employee
                    {
                        Id = 3,
                        Name = "Zakir",
                        LastName = "Shrivastav",
                        Email = "maharajmaolana@gmail.com"
                    },
                    new Employee {
                        Id = 4,
                        Name = "husain",
                        LastName = "Jibana",
                        Email = "jibana@gmail.com"
                    }
                };


            var sort = employees.OrderByDescending(e => e.Name).ThenBy(e => e.LastName).ToList();

            foreach (var sortedEmployee in sort)
            {
                Console.WriteLine(sortedEmployee.Id + " " + sortedEmployee.Name + " " + sortedEmployee.LastName);
            }
        }
        public void ReverseExample()
        {
            List<int> numbers = new List<int>() { 4, 3, 5, 7, 89, 6, 1, 23, 2, 3, 56, 3 };

            var reverseNumbs = numbers.AsEnumerable().Reverse();

            foreach (var number in reverseNumbs) { 
                
                Console.WriteLine(number);
            }
        }
    }
}
