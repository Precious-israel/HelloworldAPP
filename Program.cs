using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print 
            Console.WriteLine("Hello World!");
            
            // Display the current date
            Console.WriteLine("Today's date: " + DateTime.Now.ToShortDateString());
        }
    }
}