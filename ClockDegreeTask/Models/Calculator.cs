using ClockDegreeTask.Exceptions;
using ClockDegreeTask.Interfaces;
using System;

namespace ClockDegreeTask.Models
{
    public class Calculator : ICalculate
    {
        public double CalculateAngle(int hours, int minutes)
        {

            if (hours < 0 || hours > 12)
            {
                throw new InvalidHoursException(hours);
            }

            if (minutes > 60 || minutes < 0)
            {
                throw new InvalidMinutesException(minutes);
            }

            double hourInDegrees = hours * 30 + minutes * 30.0 / 60;
            double minuteInDegrees = minutes * 6;

            double diff = Math.Abs(hourInDegrees - minuteInDegrees);

            if (diff > 180)
            {
                diff = 360 - diff;
            }
            return diff;
        }
    }
}