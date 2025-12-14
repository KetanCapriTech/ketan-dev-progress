using FoundationC_PracticeConsoleApp.Delegates;
using FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance;
using System;
using System.Runtime.ConstrainedExecution;

class program
{
    static void Main(string[] args)
    {
        //Operations obj = new Operations();
        //obj.Accept();

        //LogicalOperations lo = new LogicalOperations();
        //lo.Operations();

        #region :: Linq ::
        //LinqQueries lq = new LinqQueries();
        //lq.ExampleQuerySyntax();

        //LinqQueries methodSyntax = new LinqQueries();
        //methodSyntax.ExampleMethodSyntax();

        //LinqQueries mixedSyntax = new LinqQueries();
        //mixedSyntax.ExampleMixedSyntax();

        //LinqQueries oddMethodSyntax = new LinqQueries();
        //oddMethodSyntax.ExampleMethodSyntaxOdd();

        //LinqQueries evenMethodSyntax = new LinqQueries();
        //evenMethodSyntax.ExampleMethodSyntaxEven();

        //PracticeIEnumberable pe = new PracticeIEnumberable();
        //pe.ExampleIEnumerable();

        //ProjectionMethodPractice projectionMethodPractice = new ProjectionMethodPractice();
        // projectionMethodPractice.ProjectionSelect();

        //projectionMethodPractice.PojectionSelectMany();

        //projectionMethodPractice.SelectManyExample2();
        //projectionMethodPractice.WhereOperatorExample();
        //projectionMethodPractice.ExampleOfTypeOfMethodInLinq();


        //SortingMethodsExample sme = new SortingMethodsExample();
        //sme.OrderByExample1();
        //sme.OrderByExample2String();
        //sme.OrderByExample2();
        //sme.OrderByExample3String();

        //sme.OrderByDecendingExample1();
        //sme.OrderByDecendingExample2String();
        //sme.OrderByDecendingExample2();
        //sme.OrderByDecendingExample3String();

        //sme.ThenByExample1();
        //sme.ThenByDesendingExample1();

        //sme.ReverseExample();


        //QuantifierOperator qo = new QuantifierOperator();
        //qo.QuantifierOperatorEx1ALL();
        //qo.QuantifierOperatorEx1Any();
        //qo.QuantifierOperatorEx2Conatins();

        // set operation distinct 
        //SetOpperation setOpperation = new SetOpperation();
        //setOpperation.DistinctExample1();
        //setOpperation.DistinctExample2();
        //setOpperation.ExpectExample1();
        //setOpperation.ExpectExample2();

        //setOpperation.IntersectExample1();
        //setOpperation.InterSectExample2();

        //setOpperation.UnionExample1();
        //setOpperation.UnionExample2();

        //Partitioning operatoprs
        //PartitioningExample example = new PartitioningExample();
        //example.TakeExample();
        //example.TakeExample1();
        //example.TakeWhileExample1();
        //example.TakeWhileExample2();
        //example.SkipExample1();
        //example.SkipWhileExample1();
        //example.SkipWhileExample2();

        // pagaination mini console app
        PaginationExample paginationExample = new PaginationExample();
        paginationExample.paginationImp();
        #endregion

        #region :: Object Oriented Programming ::

        //EncapsulationExBankAccount acc = new EncapsulationExBankAccount();
        //acc.Deposit(5000);
        //Console.WriteLine(acc.GetBalance());

        //abstarction ex
        //Vehicle v = new AbstractionExampleCar();
        //v.Start();

        //Inheritnace
        //Dog d = new Dog();
        //d.Eat();
        //d.Bark();

        // oops mini project
        //EmployeeOOPSMiniProject miniProject = new EmployeeOOPSMiniProject();
        //miniProject.Run();
        #endregion


        #region :: Delegates ::

        //Delegate is a type-safe reference to a method that allows methods to be passed as parameters.
        /*
         * Event handling
         * Callbacks
         *LINQ
         * Multicast methods
         */

        //DelegateExample demo = new DelegateExample();
        //demo.Run();

        //AdvancedDelegateExample example = new AdvancedDelegateExample();
        //example.Run();


        #endregion
    }
}