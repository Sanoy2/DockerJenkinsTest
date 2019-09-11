using DockerJenkinsTest;
using NUnit.Framework;

namespace Tests
{
    public class Tests1
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void _5and5is10()
        {
            var a = 5;
            var b = 5;
            int expected = 10;

            int result = calculator.Add(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void _5p5and5is10()
        {
            var a = 5.5;
            var b = 5;
            int expected = 10;

            int result = calculator.Add(a, b);

            Assert.AreEqual(expected, result);
        }
    }
}