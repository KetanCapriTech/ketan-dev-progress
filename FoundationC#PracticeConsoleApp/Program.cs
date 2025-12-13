using FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance;
using System;

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

        ProjectionMethodPractice projectionMethodPractice = new ProjectionMethodPractice();
        projectionMethodPractice.ProjectionOpertaion();
        #endregion
    }
}