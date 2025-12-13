using System;

namespace FoundationC_PracticeConsoleApp.Delegates
{
    internal class AdvancedDelegateExample
    {
        // Delegate declaration
        public delegate void OrderNotification(string message);

        // Methods matching delegate signature
        void EmailNotification(string msg)
        {
            Console.WriteLine("Email Sent: " + msg);
        }

        void SmsNotification(string msg)
        {
            Console.WriteLine("SMS Sent: " + msg);
        }

        void LogNotification(string msg)
        {
            Console.WriteLine("Log Entry: " + msg);
        }

        // Business logic method using delegate (CALLBACK)
        void ProcessOrder(OrderNotification notify)
        {
            Console.WriteLine("Order is being processed...");

            // callback
            notify?.Invoke("Order processed successfully");
        }

        // Runner method
        public void Run()
        {
            OrderNotification notifications = null;

            // Multicast delegate
            notifications += EmailNotification;
            notifications += SmsNotification;
            notifications += LogNotification;

            ProcessOrder(notifications);
        }
    }
}
