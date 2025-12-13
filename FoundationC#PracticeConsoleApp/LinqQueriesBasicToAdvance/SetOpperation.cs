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
    }
}
