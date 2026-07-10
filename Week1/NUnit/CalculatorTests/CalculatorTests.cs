using NUnit.Framework;
using CalcLibrary;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }

        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(-5, 10, 5)]
        public void AdditionTest(double a, double b, double expected)
        {
            double result = calculator.Addition(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}