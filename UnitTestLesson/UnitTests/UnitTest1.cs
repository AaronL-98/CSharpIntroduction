using CodeToTest;
using NUnit.Framework;


namespace UnitTests
{
    public class GreetingTests
    {
        // Partition 1 
        [Test]
        public void GivenTimeOf21_Greeting_ReturnsGoodEvening()
        {
            //Arrange   -- Inputs
            var time = 21;
            var expectedGreeting = "Good Evening";
            //Act       -- Actions
            var result = Program.Greeting(time);
            //Assert    -- Expected output
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GivenTimeOf21_Greeting_ReturnsGoodEvening_Refactored()
        {

            // Refactoring of Above Test
            Assert.That(Program.Greeting(21), Is.EqualTo("Good Evening"));
        }
        // Partition 2 5 - 11:59
        [Test]
        public void GivenTimeOf8_Greeting_ReturnsGoodMorning()
        {
            var time = 8;
            var expectedGreeting = "Good Morning";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GivenTimeOf9_Greeting_ReturnsGoodMorning()
        {
            var time = 9;
            var expectedGreeting = "Good Morning";
            var result = Program.Greeting(time);
            Assert.AreEqual(result, expectedGreeting);
        }
        // Partition 3 12 - 18
        [Test]
        public void GivenTimeOf13_Greeting_ReturnsGoodAfternoon()
        {
            Assert.That(Program.Greeting(13), Is.EqualTo("Good Afternoon"));
        }
        // Partition 4
        [Test]
        public void GivenTimeOf3_Greeting_ReturnsGoodAfternoon()
        {
            Assert.That(Program.Greeting(3), Is.EqualTo("Good Evening"));
        }
    }
}