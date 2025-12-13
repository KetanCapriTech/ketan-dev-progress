using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationC_PracticeConsoleApp.Model;

namespace FoundationC_PracticeConsoleApp.Fundamentals
{
    internal class LogicalOperations
    {
        // write a program to calculate simple intrest
        // write a program to calculate compound intrest
        // write a program to calculate area of circle and tringle
        // write a program to convert feet to inch and inch to feet
        // write a program to reverse three digit number
        // write a program to check odd or even number
        // write a program to check leap number or not
        // write a program to check given number is divisible by 3/ 5 or both

        internal void Operations()
        {
            int option = 0;
            Console.WriteLine("Enter which service you want");
            Console.WriteLine("1 for simple intrest");
            Console.WriteLine("2 for compound intrest");
            Console.WriteLine("3 for calculating area of circle");
            Console.WriteLine("4 for calculating area of Tringle");
            Console.WriteLine("5 for convert inch to feet");
            Console.WriteLine("6 for convert feet to inch");
            Console.WriteLine("7 for reverse the number");
            Console.WriteLine("8 Check Odd Even number");
            Console.WriteLine("9 Check leap year");
            Console.WriteLine("10 check number is divisble by 3 or 5 or both");
            option = Convert.ToInt32(Console.ReadLine());

            #region :: switch cases ::
            switch (option) {
                case 1:
                    InputSimpleIntrest();
                    break;

                case 2:
                    InputCompundIntrest();
                    break;

                case 3:
                    InputAreaOfCircle();
                    break;

                case 4:
                    InputAreaOfTringle();
                    break;

                case 5:
                    InputInchToFeet();
                    break;

                case 6:
                    InputFeetToInch();
                    break;

                case 7:
                    InputReverseDigit();
                    break;

                case 8:
                    InputOddOrEven();
                    break;

                case 9:
                    InputCheckLeapYear();
                    break;

                case 10:
                    InputCheckDivBy3or5();
                    break;

                default:
                    Console.WriteLine("You are allowed to choose" +
                        " only given options");
                    break;
            }
            #endregion
        }

        #region :: SimpleIntrest ::
        internal void InputSimpleIntrest()
        {
            float i, p, t;

            Console.WriteLine("please enter intreset amount : ");
            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter principle amount");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter time");
            t =Convert.ToInt32(Console.ReadLine());

            float result = CalculateSimpleIntrest(i,p,t);
            Console.WriteLine("your simple intrest :- ",result);
        }

        internal float CalculateSimpleIntrest(float intrest , float principle, float time)
        {
            float result = intrest * principle * time / 100;
            return result;
        }
        #endregion

        #region :: calculate compound Intrest ::
        internal void InputCompundIntrest()
        {
            decimal p, r, t;
            int n;
            /*
             * principal = 1000
               rate = 0.05  -> 5%
               time = 10    -> 10 years
               n = 12       -> Monthly compounding
             */

            Console.WriteLine("Enter principle amount: ");
            p  = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter rate :");
            r = decimal.Parse(Console.ReadLine()!);

            if (r > 1)
            {
               r =  r / 100;
            }

            Console.WriteLine("Enter time (in year) : ");
            t = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter n (monlthy componding) : ");
            n = int.Parse(Console.ReadLine()!);

            CompoundIntrestDto result = CalculateCompundIntrest(p, r, t, n);
            Console.WriteLine($"Final Amount {result.Amount}");
            Console.WriteLine($"Compound Interest: {result.Principal}");
        }

        internal CompoundIntrestDto CalculateCompundIntrest(decimal principle, decimal rate, decimal time , int n)
        {
            decimal amount = principle * (1 + rate / n) * n * time;
            decimal compundIntrest = amount - principle;

            CompoundIntrestDto dto = new CompoundIntrestDto
            {
               Amount = amount,
               Principal = principle,
            };

            return dto;
            
        }
        #endregion

        #region :: calculate area of circle ::

        internal void InputAreaOfCircle()
        {
            double radius;
            Console.WriteLine("Enter the radius :- ");

            radius = double.Parse(Console.ReadLine()!);

            double result = CalculateAreaOfCircle(radius);
            Console.WriteLine($"Area of circle is : {result}");
        }
        
        internal double CalculateAreaOfCircle(double radius)
        {
            double result = 3.14159 * radius * radius;
            return result;
        }
        #endregion

        #region :: calculate area of tringle ::
        internal void InputAreaOfTringle()
        {
            double baseOfTringle, heightOfTringle;
            Console.WriteLine("Enter Base of tringle : ");
            baseOfTringle = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the height of tringle :");
            heightOfTringle = double.Parse(Console.ReadLine()!);

            double areaOfTringle = CalculateAreaOfTringle(baseOfTringle, heightOfTringle);
            Console.WriteLine($"The Area of tringle is {areaOfTringle}");
        }

        internal double CalculateAreaOfTringle(double baseOfTringle, double heightOfTringle)
        {
            double areaOfTringle = 0.5 * baseOfTringle * heightOfTringle;
            return areaOfTringle;
        }
        #endregion

        #region :: convert inch to feet ::
        internal void InputInchToFeet()
        {
            double inch;

            Console.WriteLine("Enter Inch : ");
            inch = double.Parse(Console.ReadLine()!);

            double feet = ConvertInchToFeet(inch);
            Console.WriteLine($"{inch} inch is {feet} feet");
        }

        internal double ConvertInchToFeet(double inch)
        {
            double feet = inch / 12;
            return feet;
        }
        #endregion

        #region :: convert Feet to Inch ::
        internal void InputFeetToInch()
        {
            double feet;

            Console.WriteLine("Enter Feet : ");
            feet = double.Parse(Console.ReadLine()!);

            double inch = ConvertFeetToInch(feet);
            Console.WriteLine($"{feet} feet is {inch} inch");
        }

        internal double ConvertFeetToInch(double feet)
        {
            double inch = feet * 12;
            return inch;
        }
        #endregion

        #region :: reverse digit ::
        internal void InputReverseDigit()
        {
            Console.WriteLine("Enter the number to reverse");
            int n = Convert.ToInt32(Console.ReadLine());

            var result = ReverseThreeDigitNumber(n);
            Console.WriteLine($"User result {result}");
        }

        internal int ReverseThreeDigitNumber(int number)
        {
            string temp = "";

            foreach(char c in number.ToString())
            {
                temp = c + temp;
            }
            int reversedNumber = Convert.ToInt32(temp);
            return reversedNumber;
        }
        #endregion

        #region :: check odd or even number ::
        internal void InputOddOrEven()
        {
            string number = "";
            Console.WriteLine("Enter the number :");
            number = Console.ReadLine()!;

            string result = OddOrEven(number);
            Console.WriteLine($"{number} is {result}" );
        }

        internal string OddOrEven(string number) {

            string result = Convert.ToInt32(number) % 2 == 0 ? "Even number" : "Odd number";
            return result;
        }
        #endregion

        #region :: Check Leap year ::
        internal void InputCheckLeapYear()
        {
            int year = 0;
            Console.WriteLine("Enter the Year to check Leap year or not : ");
            year = Convert.ToInt32(Console.ReadLine());

            string result = checkLeapYear(year);
            Console.WriteLine($"{year} is {result}");
        }

        internal string checkLeapYear(int year)
        {
            string result = year % 400 == 0 || year % 4 == 0 && year % 100 != 0 ? "Leap Year" : "Not a Leap year";
            return result;
        }
        #endregion

        #region :: Check Given number is divisible by 3 or 5 or both ::
        internal void InputCheckDivBy3or5()
        {
            int number = 0;
            Console.WriteLine("Please enter the number to check divisible by 3 or 5 or both ");
            number = Convert.ToInt32(Console.ReadLine());

            string result = CheckDivisibleBy3or5(number);
            Console.WriteLine($"{number} is {result}");
        }

        // nested ternary operator 
        internal string CheckDivisibleBy3or5(int num)
        {
            string result = num % 3 == 0 && num % 5 == 0 ? "Divisible by both 3 and 5"
                : num % 3 == 0 ? "Divisible by 3"
                : num % 5 == 0 ? "Divisible by 5" : "not divisible by both 3 and 5";

            return result; 
        }
        #endregion

    }
}
