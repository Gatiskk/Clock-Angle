using System;

namespace ClockDegreeTask.Exceptions
{
    public class InvalidHoursException : Exception
    {
        public InvalidHoursException(int hours) : base($"Given hours:{hours} are not valid") { }
    }
}