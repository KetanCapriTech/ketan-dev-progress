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

        public void ElementFirst()
        {

            var numbers = new List<int> { 10, 20, 30 };
            // here both work same but using where performance whill be slow as compare to using only with first() approch

            int result = numbers.Where(x => x > 20).First();
            int result1 = numbers.First(x => x > 20);

            Console.WriteLine(result1);

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
                new Person { Id = 1, Name = "Alice" , password = "ABC"},
                new Person { Id = 2, Name = "Bob" , password = "Bob"},
                new Person { Id = 3, Name = "bor" , password = "rob"},
                new Person { Id = 4, Name = "nob" , password = "nob"},
            };

            var check = people.Where(x =>x.Name == "Bob" && x.Id == 2 && x.password == "Bob").FirstOrDefault();

            var person = people.FirstOrDefault(p => p.Id == 3);

            if (person == null)
            {
                Console.WriteLine("Person not found");
            }
 
        }


        public void ExampleLast()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = numbers.Last();
            Console.WriteLine(result);
        }

        public void ExampleLastOrDefault()
        {

            List<Person> list = new List<Person>() {
            new Person(){Id = 1, Name =" Somesh"},
            new Person(){Id = 2, Name =" rajesh"},
            new Person(){Id = 3, Name =" rakesh"},
            new Person(){Id = 4, Name =" divesj"},
            new Person(){Id = 5, Name =" labhesh"},
            };

            var getLast = list.Where(x => x.Id != 5).LastOrDefault();
            var getLast1 = list.LastOrDefault(x => x.Id !=5);

            Console.WriteLine(getLast.Id + " " + getLast.Name);
            Console.WriteLine(getLast1.Id + " " + getLast1.Name);
        }

        public void SingleExample()
        {
            List<int> List = new List<int>() { };
            List<int> List1 = new List<int>() { 1};
            List<int> List2 = new List<int>() { 1, 2};
            List<int> List3 = new List<int>() { 1, 2,3};

            //var reslut = List.Single(); // it will give exception Sequence contains no elements'
            var reslut = List.SingleOrDefault(); // it will return 0 
            //var reslut1 = List1.Single(); // now it will return 1
            var reslut1 = List1.SingleOrDefault(); // will return 1
            //var reslut3 = List3.Where(x => x > 2).Single(); //  now it will return 3
            var reslut3 = List3.Where(x => x > 2).SingleOrDefault(); // it return 3

            // also we can write it like this for best performance
            var shortHand = List3.SingleOrDefault(X => X > 2);

            Console.WriteLine(shortHand);
        }

        /*
         Difference

            First()
            Used to return first element from a datasource.
            If more than one element exist then this method will return first element from sequence.

            FirstOrDefault()
            Used to return first element from a datasource.
            If more than one element exist then this method will return first element from sequence.

            Last()
            Used to return last element from a datasource.
            If more than one element exist then this method will return last element from sequence.

            LastOrDefault()
            Used to return last element from a datasource.
            If more than one element exist then this method will return last element from sequence.

            Single()
            Used to return single specific element from a datasource.
            If more than one element exist then this method will throw an exception.

            SingleOrDefault()
            Used to return single specific element from a datasource.
            If more than one element exist then this method will throw an exception.

         */
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string password { get; set; }
    }
}
