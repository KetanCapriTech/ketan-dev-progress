using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp
{
    public class LinqQueries
    {
        // A linq provides is software that implements LQueryable interface for a perticular data store
        // in other words it allow to write linq queries again the data store

        // to work with a linq query we need following things
        // Data source
        // Query
        // Execution

        // wach query is a combination of Initalization | Condition | Selection |

        // There are 3 major ways to write a query in LINQ
        // 1 Query syntax
        // 2 Method Syntax
        // Mixed Syntax

        // Example 1 Query syntax

        public void ExampleQuerySyntax()
        {
            List<int> list = new List<int>() { 1,2 ,3,4 ,5,6,7,8,9 };

            var querySyntax = from obj in list
                              where obj > 2
                              select obj;

            foreach(var item in querySyntax)
            {
                Console.WriteLine(item);
            }
        }

        public void ExampleMethodSyntax()
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};

            var methodSyntax = list.Where(obj => obj < 5);

            foreach(var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
        }

        public void ExampleMixedSyntax()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var mixedSyntax = (from obj in list
                               where obj > 3
                               select obj).Select(obj => obj);

            foreach (var item in mixedSyntax)
            {
                Console.WriteLine(item);
            }

        }
    }
}
