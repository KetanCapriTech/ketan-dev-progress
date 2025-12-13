using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.OOPS
{
    //Inheritance allows:
    //One class to reuse another class
    //Child class gets parent properties

    internal class InheritanceExampleAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog : InheritanceExampleAnimal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
}
