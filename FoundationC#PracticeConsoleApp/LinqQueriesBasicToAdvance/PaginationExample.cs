using FoundationC_PracticeConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance
{
    public class PaginationExample
    {
        public void paginationImp()
        {

            int totalPage = 5;

            do
            {
                Console.WriteLine("Enter the page number");
                int num = Convert.ToInt32(Console.ReadLine());

                var ms = GetEmployees().Skip((num - 1) * totalPage).Take(totalPage);

                foreach( var item in ms)
                {
                    Console.WriteLine($"id : {item.Id} Name : {item.Name} Email : {item.Email}");
                }

            } while (true);

        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee { Id = 1, Name = "Amit", Email = "amit@gmail.com" },
                new Employee { Id = 2, Name = "Rohit", Email = "rohit@gmail.com" },
                new Employee { Id = 3, Name = "Sneha", Email = "sneha@gmail.com" },
                new Employee { Id = 4, Name = "Pooja", Email = "pooja@gmail.com" },
                new Employee { Id = 5, Name = "Kiran", Email = "kiran@gmail.com" },
                new Employee { Id = 6, Name = "Anil", Email = "anil@gmail.com" },
                new Employee { Id = 7, Name = "Neha", Email = "neha@gmail.com" },
                new Employee { Id = 8, Name = "Vikas", Email = "vikas@gmail.com" },
                new Employee { Id = 9, Name = "Sunita", Email = "sunita@gmail.com" },
                new Employee { Id = 10, Name = "Rahul", Email = "rahul@gmail.com" },
                new Employee { Id = 11, Name = "Arjun", Email = "arjun@gmail.com" },
                new Employee { Id = 12, Name = "Meena", Email = "meena@gmail.com" },
                new Employee { Id = 13, Name = "Suresh", Email = "suresh@gmail.com" },
                new Employee { Id = 14, Name = "Kavita", Email = "kavita@gmail.com" },
                new Employee { Id = 15, Name = "Manoj", Email = "manoj@gmail.com" },
                new Employee { Id = 16, Name = "Deepak", Email = "deepak@gmail.com" },
                new Employee { Id = 17, Name = "Rina", Email = "rina@gmail.com" },
                new Employee { Id = 18, Name = "Nikhil", Email = "nikhil@gmail.com" },
                new Employee { Id = 19, Name = "Komal", Email = "komal@gmail.com" },
                new Employee { Id = 20, Name = "Sanjay", Email = "sanjay@gmail.com" },
                new Employee { Id = 21, Name = "Payal", Email = "payal@gmail.com" }
            };
        }
    }
}
