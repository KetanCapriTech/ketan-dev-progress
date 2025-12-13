using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.OOPS
{
    internal class Shape : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
}
