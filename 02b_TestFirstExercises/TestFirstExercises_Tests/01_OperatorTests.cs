using NUnit.Framework;
using TestFirstExercises;

namespace TestFirstExercises_Tests
{
    public class OperatorTests
    {
        [TestCase(5, 2, true)]
        [TestCase(2, 5, false)]
        [TestCase(5, 5, true)]
        [TestCase("4", "1", true)] // convert to int and run test
        [TestCase("1", "4", false)] // convert to int and run test
        public void GivenTwoNumbersXY_GreaterEqual_ReturnsWhetherXIsGreatorOrEqualToY(int x, int y, bool expResult)
        {
            Assert.That(Methods.GreaterEqual(x, y), Is.EqualTo(expResult));
        }

        [TestCase(0, 10.429)]
        [TestCase(10, 24.714)]
        [TestCase("10", 24.714)] // Pass
        [TestCase("0", 10.429)] // Pass
        [TestCase(-5, 14.000)] // Pass
        [TestCase(150, 3224.714)] // Pass
        public void GivenNumber_BODMAS_ReturnsTheExpectedResult(int num, double expResult)
        {
            Assert.That(Methods.BODMAS(num), Is.EqualTo(expResult));
        }

        [TestCase(-2)]
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(348)]
        [TestCase("24")] // pass
        [TestCase("2")] // Pass
        [TestCase("2.0")] // Fail
        public void WhenTheArgumentIsEven_EvenOdd_ReturnsTrue(int x)
        {
            var result = Methods.EvenOdd(x);
            Assert.IsTrue(result);
        }

        [TestCase(-3)]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(347)]
        [TestCase("23")] // pass
        [TestCase("1")] // Pass
        [TestCase("1.0")] // Fail
        public void WhenTheArgumentIsOdd_EvenOdd_ReturnsFalse(int x)
        {
            var result = Methods.EvenOdd(x);
            Assert.IsFalse(result);
        }
    }
}
