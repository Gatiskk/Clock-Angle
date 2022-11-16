﻿using System;

namespace ClockDegreeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the Minutes : ");
            int minutes = int.Parse(Console.ReadLine());

            double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minuteInDegrees = minutes * 6;

            double diff = Math.Abs(hourInDegrees - minuteInDegrees);

            if (diff > 180)
            {
                diff = 360 - diff;
            }

            Console.WriteLine($"Angle between {hours} hour and {minutes} minute is {diff} degrees");
            Console.ReadKey();
        }
    }
}