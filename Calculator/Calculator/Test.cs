using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    public class Test
    {
        
        private CalculatorEx _cal;
        [SetUp]
        public void Init()
        {
           _cal = new CalculatorEx();
        }
        [Test]
         
            public void Addition()
        {
            Assert.That(_cal.addition(5,5),Is.EqualTo(10));
        }

        [TestCase(2,5,-3)]
        [TestCase(-2,5,-7)]
        [TestCase(200,5000,-4800)]

        public void Subtraction(double a, double b, double x)
        {
            Assert.That(_cal.subtract(a,b).Equals(x));
        }
        [TestCase(2,5,10)]
        [TestCase(-2,5,-10)]
        [TestCase(200,5000,1000000)]
        public void Multiply(double a, double b, double x)
        {
            Assert.That(_cal.multiply(a,b),Is.EqualTo(x));
        }

        [TestCase(2, 3, 8)]
        [TestCase(2, 5, 32)]
        [TestCase(3, 3, 27)]
        public void Power(double a, double b, double x)
        {
            Assert.That(_cal.power(a,b).Equals(x));
        }
    }
}