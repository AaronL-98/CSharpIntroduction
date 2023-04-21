using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [TestCase(1, 3)]
        [TestCase(6, 10)]
        [TestCase(1000, 3)]
        [TestCase(516, 4)]
        public void GivenSeed_RollDice_ReturnsIntBetweenOneAndTwelve(int seed, int expected)
        {
            Random rng = new Random(seed);
            int result = Methods.RollDice(rng);
            Assert.That(result, Is.InRange   (1,12));
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
