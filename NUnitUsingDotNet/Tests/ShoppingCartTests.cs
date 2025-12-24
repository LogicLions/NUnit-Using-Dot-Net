using Moq;
using NUnitUsingDotNet.Interfaces;
using NUnitUsingDotNet.Models;

namespace NUnitUsingDotNet.Tests
{
    [TestFixture]
    public class ShoppingCartTests
    {
        private Mock<IProductRepository> _mockProductRepository;
        private ShoppingCart _shoppingCart;

        [SetUp]
        public void Setup() 
        {
            _mockProductRepository = new Mock<IProductRepository>();
            _shoppingCart = new ShoppingCart(_mockProductRepository.Object);
        }

        [Test]
        public void AddItem_WhenProductExists_ReturnsSuccessMessage() 
        {
            // Arrange
            int productId = 1;
            var expectedProduct = new Product { Id = productId, Name = "Laptop", Price = 999.99m };

            // Tell the mock to return the 'expectedProduct' when 'GetProductById' is called with 'productId'
            _mockProductRepository.Setup(repo => repo.GetProductById(productId)).Returns(expectedProduct);

            // Act
            string result = _shoppingCart.AddItem(productId);

            // Assert
            Assert.That(result, Is.EqualTo("Added Laptop"));

            // Optionally, verify the mock method was called exactly once with correct parameter.
            _mockProductRepository.Verify(repo => repo.GetProductById(productId), Times.Once);
        }

        [Test]
        public void AddItem_WhenProductNotExists_ReturnNotFoundMessage() 
        {
            // Arrange
            int nonExistentProductId = 99;

            // tell mock to return 'null' when 'GetProductById' is called.
            _mockProductRepository.Setup(repo => repo.GetProductById(It.IsAny<int>())).Returns((Product)null); // Use null for non existent product

            // Act
            string result = _shoppingCart.AddItem(nonExistentProductId);

            // Assert
            Assert.That(result, Is.EqualTo("Product not found."));
        }
    }
}
