using HelperLibrary;
using NUnit.Framework;

namespace Test.HomeWork
{
    public class Tests
    {

        [TestCase(1, 60)]
        [TestCase(2, 120)]
        [TestCase(3, 180)]
        public void CalculateMinutes_WhenHoursShouldCalculateInMinutes (int hours, int expected)
        { 
           
            int actual = LinearEquations.CalculateMuntes(hours);

            Assert.AreEqual(expected, actual);
        }
    }
}