using System;

namespace ClockDegreeTask.Exceptions
{
    public class InvalidMinutesException: Exception
    {
        public InvalidMinutesException(int minutes) : base($"Given minutes:{minutes} are not valid") { }
    }
}