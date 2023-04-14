using Microsoft.Win32.SafeHandles;
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
        [TestCase(-156, -11)]
        public void GivenTotalPounds_GetStones_ReturnNumberOfStones(int totalPounds, int expected)
        {
            Assert.That(Methods.GetStones(totalPounds), Is.EqualTo(expected));
        }

        [TestCase(1)] // Pass
        [TestCase(156)] // Fail
        [TestCase("156")] // Pass
        public void GivenTotalPounds_GetStones_ReturnNumberOfStones(int totalPounds)
        {
            Assert.NotZero(Methods.GetStones(totalPounds));
        }

        [TestCase(156, 2)] // Pass
        [TestCase(156, 4)] // Fail
        [TestCase((int)156.0, 2)] // Fail
        [TestCase("156", 2)] // Pass
        public void GivenTotalPounds_GetPounds_ReturnRemainingNumberOfPounds(int totalPounds, int expected)
        {
            Assert.That(Methods.GetPounds(totalPounds), Is.EqualTo(expected));
        }
    }
}
