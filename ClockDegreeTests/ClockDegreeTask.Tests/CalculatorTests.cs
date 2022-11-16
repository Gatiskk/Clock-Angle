using ClockDegreeTask.Exceptions;
using ClockDegreeTask.Models;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace ClockDegreeTests.ClockDegreeTask.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void CalculateAngle_AngleIsCorrect()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.CalculateAngle(3, 30);

            //Assert
            result.Should().Be(75);
        }

        [Test]
        public void CalculateAngle_AngleIsCorrect_Minutes60()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.CalculateAngle(3, 60);

            //Assert
            result.Should().Be(120);
        }

        [Test]
        public void CalculateAngle_AngleIsCorrect_Hours12()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.CalculateAngle(12, 30);

            //Assert
            result.Should().Be(165);
        }

        [Test]
        public void CalculateAngle_AngleIsCorrect_Hours0AndMinutes0()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.CalculateAngle(0, 0);

            //Assert
            result.Should().Be(0);
        }

        [Test]
        public void CalculateAngle_AngleIsCorrect_HoursAreNegative()
        {
            //Arrange
            var calculator = new Calculator();

            //Assert & Act
            Action act = () => calculator.CalculateAngle(-2, 30);
            act.Should().Throw<InvalidHoursException>()
                .WithMessage($"Given hours:{-2} are not valid");
        }

        [Test]
        public void CalculateAngle_AngleIsCorrect_MinutesAreNegative()
        {
            //Arrange
            var calculator = new Calculator();

            //Assert & Act
            Action act = () => calculator.CalculateAngle(2, -30);
            act.Should().Throw<InvalidMinutesException>()
                .WithMessage($"Given minutes:{-30} are not valid");
        }

        [Test]
        public void CalculateAngle_AngleIsCorrect_HoursWrongValue()
        {
            //Arrange
            var calculator = new Calculator();

            //Assert & Act
            Action act = () => calculator.CalculateAngle(22, 0);
            act.Should().Throw<InvalidHoursException>()
                .WithMessage($"Given hours:{22} are not valid");
        }

        [Test]
        public void CalculateAngle_AngleIsCorrect_MinutesWrongValue()
        {
            //Arrange
            var calculator = new Calculator();

            //Assert & Act
            Action act = () => calculator.CalculateAngle(2, 65);
            act.Should().Throw<InvalidMinutesException>()
                .WithMessage($"Given minutes:{65} are not valid");
        }
    }
}