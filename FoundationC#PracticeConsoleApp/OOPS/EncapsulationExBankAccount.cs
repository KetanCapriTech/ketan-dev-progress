using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.OOPS
{
    public class EncapsulationExBankAccount
    {
        //Encapsulation (Data Hiding)
        /*
         Binding data and methods together
         Hiding internal details
         Access data using properties
         */

        private double balance; 

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }

}
