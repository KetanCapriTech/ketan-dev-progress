using FoundationC_PracticeConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance
{
    public class PracticeIEnumberable
    {
        //IEnumerable is an interface
        //IEnumberable is available in System.Collection namespace
        //All the collection in C# implements IEcumnerable

        public void ExampleIEnumerable()
        {
            List<Students> students = new List<Students>() { 
                new Students(){Id = 1, Name ="ketan"},
                new Students(){Id =2 , Name= "Swayam"}
            };

            // example of query syntax 
            var employe = from std in students
                          where std.Id == 1
                          select std;

            // method syntax
            IEnumerable<Students> student = students.Where(s => s.Id ==1 || s.Name == "keatn").ToList();

            IQueryable<Students> student1 = students.AsQueryable().Where(s => s.Id ==1 && s.Name == "ketan");


            foreach (var item in student1)
            {
                Console.WriteLine(item.Id +" " + item.Name);
            }

            /*
            Use IEnumerable when:
            Data is already in memory
            we are working with arrays or lists
            we don’t need DB optimization

            Use IQueryable when:
            Querying a database
            we want filtering, sorting, paging in SQL
            we want better performance
             */
        }

    }
  
}
