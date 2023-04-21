using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [TestCase(4, 16, 64, 2.0)]
        [TestCase(7, 49, 343, 2.6457513110645905905016157536393)]
        public void GivenANumber_PowersRoot_ReturnsCorrectTuple(
        int input, int expectedSquare, int expectedCube, double expectedRoot)
        {
            var answer = Methods.PowersRoot(input);
            Assert.That(answer.squareInput, Is.EqualTo(expectedSquare), "Incorrect Square");
            Assert.That(answer.cubeInput,   Is.EqualTo(expectedCube), "Incorrect Cube");
            Assert.That(answer.sqrtInput,   Is.EqualTo(expectedRoot), "Incorrect Root");
        }
        [Test]
        public void GivenANegativeNumber_PowersRoot_ThrowsAnException()
        {
            Assert.That(() => Methods.PowersRoot(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("Can't sqaure root a negative number"));
        }


    }

}