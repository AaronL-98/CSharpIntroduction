using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [TestCase(10, 10, false)]
        public void MyMethod_ReturnsFalseIfParametersEqual(int num1, int num2, bool expected)
        {
            Console.WriteLine(Exercises.MyMethod(num1, num2));
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(expected));
        }
        [TestCase(5, 10, false)]
        [TestCase(10, 5, true)]
        public void MyMethod_ReturnsIfNum1DevisableByNum2(int num1, int num2, bool expected)
        {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(expected));
        }



        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ThrowException()
        {
            var myList = new List<int>() {};
            Assert.Throws<ArgumentOutOfRangeException>(() => Exercises.Average(myList)).Message.Contains("List Empty");
        }

        [Test]
        public void WhenListIsNull_Average_ReturnsThrowException()
        {
            var myList = new List<int>();
            try
            {
                double i = Exercises.Average(myList);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Exercises.Average(myList)).Message.Contains("Parameter was Null");

            }
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        public class GradeTests
        {
            [TestCase(0, "Fail")]                   // Pass
            [TestCase(40, "Pass")]                  // Pass
            [TestCase(61, "Pass with Merit")]       // Pass
            [TestCase(76, "Pass with Distinction")] // Pass
            public void GivenScore_CheckGrade_ReturnStringContainingGrade(int score, string expected)
            {
                try
                {
                    Assert.That(Exercises.Grade(score), Is.EqualTo(expected));
                }
                catch (Exception e)
                {
                    Assert.Throws<ArgumentOutOfRangeException>(() => Exercises.Grade(score));

                }
            }
        }

        public class MaxWeddingNumbersTests
        {
            [TestCase(4, 20)]
            [TestCase(3, 50)]
            [TestCase(2, 50)]
            [TestCase(1, 100)]
            [TestCase(0, 200)]
            public void GivenCovidLevel_GetScottishMaxWeddingNumbers_RetrunsMaxAttendees(int covidLevel, int expected)
            {
                Assert.That(Exercises.GetScottishMaxWeddingNumbers(covidLevel), Is.EqualTo(expected));
            }

            [TestCase(5)]
            [TestCase(-1)]
            public void GivenCovidLevel_GetScottishMaxWeddingNumbers_RetrunsMaxAttendees(int covidLevel)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Exercises.GetScottishMaxWeddingNumbers(covidLevel));
            }
        }
    }
}
