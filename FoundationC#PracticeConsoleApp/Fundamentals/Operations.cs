using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.Fundamentals
{
    internal class Operations
    {
        int a, b, c;
        int operationType = 0;
        internal void Accept()
        {
            Console.WriteLine("Please select the opration 1 for add , 2 for substract, 3 for multiplication, 4 for divsion");
            operationType = Convert.ToInt32(Console.ReadLine());

            if (operationType == 1 || operationType == 2 || operationType == 3 || operationType == 4)
            {
                Console.WriteLine("Please enter the 1st number");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the 2nd number");
                b = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Only option 1,2,3,4 are allowed");
            }

                switch (operationType)
                {
                    case 1:
                        Add();
                        break;

                    case 2:
                        Sub();
                        break;

                    case 3:
                        Multi();
                        break;

                    case 4:
                        Div();
                        break;
                }
        }

        internal void Add()
        {
            c = a + b;
            Console.WriteLine("Total :- "+ c);
        }

        internal void Sub()
        {
            c = a - b ;
            Console.WriteLine("Total :- " + c);
        }

        internal void Multi()
        {
            c = a * b;
            Console.WriteLine("Total :- " + c);
        }

        internal void Div()
        {
            c = a / b;
            Console.WriteLine("Total :- " + c);
        }
    }
}
