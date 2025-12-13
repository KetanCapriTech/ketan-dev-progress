using FoundationC_PracticeConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance
{
    public class ProjectionMethodPractice
    {
        public void ProjectionSelect()
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "ketan" , Email= "kvfunde@gmail.com"},
                new Employee(){Id = 2, Name = "Swayam", Email="Swayam@gmail.com"},
                new Employee(){Id = 3, Name = "Divesh", Email="divesh@gmail.com"},
                new Employee(){Id = 4, Name = "Shiva", Email="Shiva@gmail.com"},
                new Employee(){Id = 5, Name = "Rakesh", Email = "rakesh@gmail.com"}
            };

            var basicQuery = (from emp in employee
                              select emp).ToList();

            var basicMethodQuery = employee.ToList();

            var selectEmploye = employee.Select(emp => new Employee() {
                Id = emp.Id,
                Name = emp.Name,
                Email = emp.Email,
            }).ToList();

            foreach (var item in selectEmploye)
            {
                Console.WriteLine(item.Id + " " + item.Name + " "+ item.Email );   
            }
        }

        public void PojectionSelectMany()
        {
            List<string> list = new List<string>() {"ketan","funde"};

            var methodQuery = list.SelectMany(x => x).ToList();

            foreach(var item in methodQuery)
            {
                Console.WriteLine(item);
            }
        }

        public void SelectManyExample2()
        {
            var dataSource = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "rajesh" , Programing = new List<string>(){"c#" , "Java", "Python"}},
                new Employee(){Id = 2, Name = "brijesh" , Programing = new List<string>(){"c++" , ".NET", "Future"}},
                new Employee(){Id = 3, Name = "somesh" , Programing = new List<string>(){"PHP" , "MYSQL", "RUby"}},
                new Employee(){Id = 4, Name = "sarvesh" , Programing = new List<string>(){"SQL" , "POSTGRES", "RAIls"}},
                new Employee(){Id = 5, Name = "divesh" , Programing = new List<string>(){"DJANGO" , "kuchbhi", "DSA"}},
            };

            var queryMethod = dataSource.SelectMany(emp => emp.Programing).ToList();

            // using syntaxQuery
            var querySyntax = (from emp in dataSource
                              from skill in emp.Programing
                              select skill).ToList();

            foreach(var item in querySyntax)
            {
                Console.WriteLine(item);
            }
        }

        public void WhereOperatorExample()
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "ketan" , Email= "kvfunde@gmail.com"},
                new Employee(){Id = 2, Name = "Swayam", Email="Swayam@gmail.com"},
                new Employee(){Id = 3, Name = "Divesh", Email="divesh@gmail.com"},
                new Employee(){Id = 4, Name = "Shiva", Email="Shiva@gmail.com"},
                new Employee(){Id = 5, Name = "Rakesh", Email = "rakesh@gmail.com"}
            };


            var methodQuery = employee.Where(emp => emp.Id != 0 && emp.Id < 5 && emp.Email.Length != 0).ToList();

            foreach(var item in methodQuery)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Email);
            }
        }

        public void ExampleOfTypeOfMethodInLinq()
        {
            var dataSource = new List<object>() {"kim" ,"deva", "john","sandy" ,"devid" ,1,2,3,4,5,6,7 , true , false, 1.2 , 5.8, 'a' , 'b' , 'c'};

            var result = dataSource.OfType<string>().ToList();

            foreach (var item in result)
            {
                Console.WriteLine(result);
            }

            foreach(var item in dataSource.OfType<int>().ToList())
            {
                Console.WriteLine(item);
            }

            foreach (var item in dataSource.OfType<bool>().ToList())
            {
                Console.WriteLine(item);
            }

            foreach (var item in dataSource.OfType<double>().ToList())
            {
                Console.WriteLine(item);
            }

            foreach (var item in dataSource.OfType<char>().ToList())
            {
                Console.WriteLine(item);
            }
        }
    }
}
