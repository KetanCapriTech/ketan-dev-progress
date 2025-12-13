using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.OOPS
{
    abstract class Vehicle
    {
        public abstract void Start();
    }

    class AbstractionExampleCar : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car starts with key");
        }
    }
}
