namespace NUnitUsingDotNet
{
    [TestFixture]
    public class MyTestCase
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
            Assert.AreEqual(expctedOutput, actualResult);
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
            Assert.AreEqual(expectedOutput, actualResult);
        }
    }
}