using OperatorsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsControlFlowTests
{
    internal class StoneTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(156, 11)] // Pass
        [TestCase(156, 14)] // Fail
        [TestCase("156", 11)] // Pass
        [TestCase(-156, -11)] // Fail
        public void GivenTotalPounds_GetStones_ReturnNumberOfStones(int totalPounds, int expected)
        {
            Assert.That(Methods.GetStones(totalPounds), Is.EqualTo(expected));
        }

        [TestCase(156, 2)] // Pass
        [TestCase(156, 4)] // Fail
        [TestCase((int)156.0, 2)] // Pass
        [TestCase("156", 2)] // Pass
        [TestCase(-156, -11)] // Fail
        public void GivenTotalPounds_GetPounds_ReturnRemainingNumberOfPounds(int totalPounds, int expected)
        {
            Assert.That(Methods.GetPounds(totalPounds), Is.EqualTo(expected));
        }

        [Test]
        public void GivenTotalPounds_GetStones_ReturnExceptionInvalidNotPositive()
        {
            Assert.Throws<ArgumentException>(() => Methods.GetPounds(-1));
        }

        [Test]
        public void GivenTotalPounds_GetStones_ReturnExceptionInvalidOverLimit()
        {
            Assert.Throws<ArgumentException>(() => Methods.GetPounds(1500));
        }

        [Test]
        public void GivenTotalPounds_GetPounds_ReturnExceptionInvalidNotPositive()
        {
            Assert.Throws<ArgumentException>(() => Methods.GetPounds(-1));
        }

        [Test] // Pass
        public void GivenTotalPounds_GetPounds_ReturnExceptionOverLimit()
        {

            Assert.Throws<ArgumentException>(() => Methods.GetPounds(1500));
        }

    }
}
