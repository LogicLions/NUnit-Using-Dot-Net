using NUnit.Framework.Legacy;

namespace NUnitUsingDotNet.Tests
{
    [TestFixture]
    public class MyMathTests
    {
        private MyMath _myMath;

        [SetUp]
        public void Setup()
        {
            _myMath = new MyMath();
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int x = 5;
            int y = 6;
            int expctedOutput = 11;

            // Act
            int actualResult = _myMath.add(x, y);

            // Assert
            // ClassicAssert.AreEqual(expctedOutput, actualResult);
            Assert.That(actualResult, Is.EqualTo(expctedOutput));
        }

        [Test]
        public void Substract_ShouldReturnCorrectSubtraction()
        {
            // Arrange
            int x = 8;
            int y = 6;
            int expectedOutput = 2;

            // Act
            int actualResult = _myMath.subtract(x, y);

            // Assert
            // ClassicAssert.AreEqual(expectedOutput, actualResult);
            Assert.That(actualResult, Is.EqualTo(expectedOutput));
        }
    }
}