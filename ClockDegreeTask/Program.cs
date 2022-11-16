using System;
using ClockDegreeTask.Models;

namespace ClockDegreeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the Minutes : ");
            int minutes = int.Parse(Console.ReadLine());

            var calculator = new Calculator();

            Console.WriteLine($"Angle between {hours} hour and {minutes} minute is {calculator.CalculateAngle(hours,minutes)} degrees");
            Console.ReadKey();
        }
    }
}