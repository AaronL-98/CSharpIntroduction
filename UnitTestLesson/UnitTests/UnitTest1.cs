using CodeToTest;
using NUnit.Framework;


namespace UnitTests
{
    public class GreetingTests
    {
        // Partition 1 19 - 4
        [TestCase(19)]
        [TestCase(23)]
        [TestCase(1)]
        [TestCase(4)]
        public void GivenTimeBetween19And4Inclusive_Greeting_ReturnsGoodEvening(int time)
        {
            //Arrange   -- Intputs
            var expectedGreeting = "Good Evening";
            //Act       -- Actions
            var result = Program.Greeting(time);
            //Assert    -- Expected output
            Assert.That(result, Is.EqualTo(expectedGreeting));

        }

        // Partition 2 5 - 11
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(9)]
        [TestCase(11)]
        public void GivenTimeBetween5And11Inclusive_Greeting_ReturnsGoodMorning(int time)
        {
            var expectedGreeting = "Good Morning";
            var result = Program.Greeting(time);
            Assert.AreEqual(result, expectedGreeting);
        }

        // Partition 3 12 - 17
        [TestCase(12)]
        [TestCase(15)]
        [TestCase(17)]
        public void GivenTimeBetween12And17Inclusive_Greeting_ReturnsGoodAfternoon(int time)
        {
            // Refactored layout of above tests
            Assert.That(Program.Greeting(time), Is.EqualTo("Good Afternoon"));
        }
    }
}