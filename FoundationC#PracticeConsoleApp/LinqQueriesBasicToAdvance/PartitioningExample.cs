using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance
{
    public class PartitioningExample
    {
        /*
         partitioning operators are used to divide data source into two parts and returns one of them as autput without changing element partitions
            TAKE , TAKEWHILE, SKIP, SKIPWHILE
         */
        public void TakeExample()
        {
            List<int> numb = new List<int>() { 1,2,3,4,5,6,7,8,9};

            var takeOnlyFive = numb.Take(5).ToArray();

            foreach (int i in takeOnlyFive)
            {
                Console.WriteLine(i);
            }
        }

        public void TakeExample1()
        {
            List<int> numb = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var takeOnlyFive = numb.Where(x => x < 3).Take(5).ToArray();

            foreach (int i in takeOnlyFive)
            {
                Console.WriteLine(i);
            }
        }

        public void TakeWhileExample1()
        {
            List<int> numb = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = numb.TakeWhile(x => x < 3).ToArray();

            //takeWhile vs where 

            List<int> numb1 = new List<int>() { 1, 5, 6, 7, 8, 9 ,2, 3, 4};

            var result1 = numb1.TakeWhile(x => x < 3).ToArray(); // this will return only 1 beacuse if contion fail it will not proceced further

            foreach (int i in result1)
            {
                Console.WriteLine(i);
            }
        }

        public void TakeWhileExample2()
        {
            List<string> names = new List<string>() { "ketan", "ramesh" , "suresh" , "brijesh" };

            var result1 = names.TakeWhile((name, index) => name.Length > index).ToList();

            foreach (string i in result1)
            {
                Console.WriteLine(i);
            }
        }

        public void SkipExample1()
        {
            List<int> numb = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var skipFive = numb.Skip(5).ToArray();

            var skipFive1 = numb.Where(x => x > 3).Skip(5).ToArray();

            foreach (int i in skipFive1)
            {
                Console.WriteLine(i);
            }
        }

        public void SkipWhileExample1()
        {
            List<int> numb = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = numb.SkipWhile(x => x < 3).ToArray();

            List<int> numb1 = new List<int>() { 1, 2, 3, 4 ,5, 6, 7, 8, 9};

            var result1 = numb1.SkipWhile(x => x < 3).ToArray(); // this will return 3, 4 ,5, 6, 7, 8, 9

            foreach (int i in result1)
            {
                Console.WriteLine(i);
            }
        }

        public void SkipWhileExample2()
        {
            List<string> names = new List<string>() { "ketan", "esh", "sh", "brijesh" };

            var result1 = names.SkipWhile((value, index) => value.Length > index).ToList();

            foreach (string i in result1)
            {
                Console.WriteLine(i);
            }
        }

    }
}
