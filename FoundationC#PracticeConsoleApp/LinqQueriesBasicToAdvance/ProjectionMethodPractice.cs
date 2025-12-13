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
        public void ProjectionOpertaion()
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
            
            foreach (var item in basicQuery)
            {
                Console.WriteLine(item.Id + " " + item.Name);   
            }
        }
    }
}
