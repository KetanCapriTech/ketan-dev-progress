using FoundationC_PracticeConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance
{
    public class ElementOperations
    {
        public void ElementAtOperation()
        {
            List<int> num = new List<int>()
            {
               1,2,3,4,5,6,7,8,9,10
            };

            List<string> str = new List<string>()
            {
                "a","b","c","d"
            };

            var result = num.Where(x => x > 3).ElementAtOrDefault(1);

            Console.WriteLine(result);
            
        }

        public void ElementFirstOrDefault()
        {

            var numbers = new List<int> { 10, 20, 30 };

            int result = numbers.FirstOrDefault();

            Console.WriteLine(result);

        }

        public void ElementFirstOrDefaultWithObject()
        {

            var people = new List<Person>
            {
                new Person { Id = 1, Name = "Alice" },
                new Person { Id = 2, Name = "Bob" }
            };

            var person = people.FirstOrDefault(p => p.Id == 3);

            if (person == null)
            {
                Console.WriteLine("Person not found");
            }

        }
   
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
