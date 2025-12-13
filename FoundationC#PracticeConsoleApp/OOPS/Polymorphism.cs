
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.OOPS
{
    /*
    Polymorphism means:
    Same method name
    Different behavior
    Types
    Compile-time (Method Overloading)
    Run-time (Method Overriding)
    */

    //Method Overloading Example
    public class PolymorphismMathOperationsOverloading
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    //Method Overriding Example
    public class PolymorphismAnimalOperationsOverriding
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
    class Cat : PolymorphismAnimalOperationsOverriding
    {
        public override void Sound()
        {
            Console.WriteLine("Meow");
        }
    }
}
