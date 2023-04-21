using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [TestCase(1)]
        [TestCase(6)]
        [TestCase(1000)]
        [TestCase(516)]
        public void GivenSeed_RollDice_ReturnsIntBetweenOneAndTwelve(int seed)
        {
            Random rng = new Random(seed);
            int result = Methods.RollDice(rng);
            Assert.That(result, Is.GreaterThanOrEqualTo( 2));
            Assert.That(result, Is.LessThanOrEqualTo   (12));
        }

        [TestCase(1, 3)]
        [TestCase(6, 10)]
        [TestCase(1000, 3)]
        [TestCase(516, 4)]
        public void GivenSeed_RollDice_ReturnsCorrectInt(int seed, int expected)
        {
            Random rng = new Random(seed);
            Assert.That(Methods.RollDice(rng), Is.EqualTo(expected));
        }

    }
}
