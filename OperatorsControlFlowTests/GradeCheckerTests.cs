using ControlFlowApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace OperatorsControlFlowTests
{
    public class GradeCheckerTests
    {
        [TestCase(-1, "Fail")]          // Fail
        [TestCase(25, "Fail")]          // Pass
        [TestCase(71, "Pass")]          // Pass
        [TestCase(91, "Distinction")]   // Pass
        [TestCase(101, "Distinction")]  // Fail
        public void GivenScore_CheckGrade_ReturnStringContainingGrade(int score, string expected)
        {
            try
            {
                Assert.That(GradeChecker.CheckGrade(score), Is.EqualTo(expected));
            }
            catch (Exception e)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => GradeChecker.CheckGrade(score));

            }
        }

        [TestCase(-12)] // Pass
        [TestCase(101)] // Pass
        public void WhenMarkLessThanZero_Grade_ThrowsArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => GradeChecker.CheckGrade(mark), 
                              Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Allowed Range 0-100"));
        }

    }
}