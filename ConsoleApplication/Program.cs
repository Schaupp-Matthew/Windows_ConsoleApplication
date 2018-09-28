using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Local variables
            var name = "Matthew Schaupp";
            var state = "North Carolina";

            //Output statement to console using string interpolation
            Console.WriteLine($"My name is {name}, and I am from {state}.");

            //Output the date without time element
            DateTime today = DateTime.Today.Date;
            Console.WriteLine("Today's date is: " + today.ToString("dd/MM/yyyy"));

            //Christmas variables and output
            int day = DateTime.Today.DayOfYear;
            int christmasDay = new DateTime(2018, 12, 25).DayOfYear;
            int daysToChristmas = christmasDay - day;
            Console.WriteLine("Days to Christmas: " + daysToChristmas);

            //Yellow Book Code
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter wood length:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            

            Console.WriteLine("Please enter glass height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("\nThe length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("\nThe area of the glass is " +
            glassArea + " square meters");

            //Wait for user to press enter to terminate program
            Console.WriteLine("\nPlease press <Enter> to terminate program.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {
            }
        }
    }
}
