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

    public class ClassificationTests
    {
        // Partition 1 age < 12
        [TestCase(11)] // Pass
        [TestCase(12)] // Fail
        public void GivenAgeLessThan12_AvailableClassification_ReturnsUPGFilmsAreAvailable(int age)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U, PG Films are available."));
        }
        // Partition 2 age < 15
        [TestCase(11)] // Fail
        [TestCase(12)] // Pass
        [TestCase(14)] // Pass
        [TestCase(15)] // Fail
        public void GivenAgeLessThan15_AvailableClassification_ReturnsUP12GFilmsAreAvailable(int age)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U, PG & 12 Films are available."));
        }
        // Partition 3 age < 18
        [TestCase(14)] // Fail
        [TestCase(15)] // Pass
        [TestCase(17)] // Pass
        [TestCase(18)] // Fail
        public void GivenAgeLessThan18_AvailableClassification_ReturnsUPG1215FilmsAreAvailable(int age)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U, PG, 12 & 15 Films are available."));
        }
        // Partition 4 age > 18
        [TestCase(17)] // Fail
        [TestCase(18)] // Pass
        public void GivenAgeGreaterThan18_AvailableClassification_ReturnsAllFilmsAreAvailable(int age)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("All Films are available."));
        }
    }
}