using System;

namespace FoundationC_PracticeConsoleApp.Delegates
{
    internal class DelegateExample
    {
        // Declare delegate
        public delegate double BonusCalculator(double salary);

        // Methods matching delegate signature
        public double FestivalBonus(double salary)
        {
            return salary * 0.10;
        }

        public double PerformanceBonus(double salary)
        {
            return salary * 0.20;
        }

        // Use delegate
        public void Run()
        {
            double salary = 50000;

            BonusCalculator bonus;

            bonus = FestivalBonus;
            Console.WriteLine("Festival Bonus: " + bonus(salary));

            bonus = PerformanceBonus;
            Console.WriteLine("Performance Bonus: " + bonus(salary));
        }
    }
}
