using FoundationC_PracticeConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance
{
    /*
     Set operations are used for those query operations that produce result set based
     on presence and absence of elements within same or seprate data source

    Example : select distinct records from a data source
     Majar area :
                Distinct : Removes Duplicate values from data source
                Intersect :- Returns all the elements which exist in both data source
                Expect :- Returns all the elements from one data source that do not exist in secound data source
                Union :- return all the elements that appear in either of two data source
     */
    public class SetOpperation
    {
        public void DistinctExample1()
        {
            List<int> ints = new List<int>() { 1,2,1,2,2,3,3,3,4,4,5,5,5,5,6,6,6,7,7};

            var unique = ints.Distinct().ToList();

            var querySyntax = (from num in unique
                              select num).Distinct().ToList();

            foreach (var num in querySyntax) { 
                Console.WriteLine(num);
            }
        }

        public void DistinctExample2()
        {
            List<Students> students = new List<Students>() {
            new Students(){Id = 1, Name = "ketan"},
            new Students(){Id = 2, Name = "rajesh"},
            new Students(){Id = 3, Name = "jiyan"},
            new Students(){Id = 4, Name = "ketan"}
            };

            var methodSyntax = students.Select(s => s.Name).Distinct().ToList();

            foreach (var num in methodSyntax)
            {
                Console.WriteLine(num);
            }
        }

        public void ExpectExample1()
        {
            List<char> list1 = new List<char>() { 'A', 'B', 'C', 'D'};
            List<char> list2 = new List<char>() { 'C', 'D', 'E', 'F'};

            var result = list1.Except(list2).ToList();
        }

        public void ExpectExample2()
        {
            List<Students> student1 = new List<Students>() { 
            new Students(){Id = 1, Name = "Ketan" },
            new Students(){Id = 2, Name = "suresh"},
            new Students(){Id = 3 , Name = "divesh"}
            };

            List<Students> student2 = new List<Students>() { 
            new Students (){Id = 4, Name = "divesh"},
            new Students(){Id = 5, Name = "Brijesh"},
            new Students(){Id=6, Name="Ketan"}
            };

            // returns the elements from 1 data source that dp noty exist in second data source
            var methodSynax = student1.Select(s => s.Name).Except(student2.Select(s => s.Name)).ToList();

            // using anonmous we can get all properties  new {s.id , s.Name}
            var methodSynaxAnon = student1.Select(s => new {s.Id , s.Name}).Except(student2.Select(s => new {s.Id , s.Name})).ToList();

            foreach(var item in methodSynax)
            {
                Console.WriteLine(item);
            }
        }

        public void IntersectExample1()
        {
            List<int> l1 = new List<int>() { 1, 2, 3, 4 };
            List<int> l2 = new List<int>() { 1, 2, 5, 6, 4 };

            var result = l1.Intersect(l2).ToList();

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void InterSectExample2()
        {
            List<Students> std1 = new List<Students>()
            {
                new Students(){Id = 1, Name ="Sarvesh"},
                new Students(){Id = 2, Name="Danny" },
                new Students(){Id = 3, Name="devid" },
            };

            List<Students> std2 = new List<Students>()
            {
                new Students(){Id = 4, Name ="vikas"},
                new Students(){Id = 5, Name="Danny" },
                new Students(){Id = 6, Name="devid" },
                new Students(){Id = 1, Name="Sarvesh" },
            };
            var result = std1.Select(s => s.Name).Intersect(std2.Select(s => s.Name )).ToList();

            var result1 = std1.Select(s => new { s.Id, s.Name }).Intersect(std2.Select(s => new { s.Id, s.Name })).ToList();

            foreach (var item in result1) { 
                Console.WriteLine(item);
            }
        }

        public void UnionExample1()
        {
            List<int> l1 = new List<int>() { 1, 2, 3, 4 };
            List<int> l2 = new List<int>() { 1, 2, 5, 6, 4 };

            var result = l1.Union(l2).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void UnionExample2()
        {
            List<Students> std1 = new List<Students>()
            {
                new Students(){Id = 1, Name ="Sarvesh"},
                new Students(){Id = 2, Name="Danny" },
                new Students(){Id = 3, Name="devid" },
            };

            List<Students> std2 = new List<Students>()
            {
                new Students(){Id = 4, Name ="vikas"},
                new Students(){Id = 5, Name="Danny" },
                new Students(){Id = 6, Name="devid" },
                new Students(){Id = 1, Name="Sarvesh" },
            };
            var result = std1.Select(s => s.Name).Union(std2.Select(s => s.Name)).ToList();

            var result1 = std1.Select(s => new { s.Id, s.Name }).Union(std2.Select(s => new { s.Id, s.Name })).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
