using NUnit.Framework;
using ECOM_PRODUCT; // 添加这一行

namespace ECOM_PRODUCT_Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void ProductID_ValidValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 10);

            // Act & Assert
            Assert.That(product.ProductID, Is.EqualTo(1));
        }

        [Test]
        public void ProductID_MinValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 10);

            // Act & Assert
            Assert.That(product.ProductID, Is.EqualTo(1));
        }

        [Test]
        public void ProductID_MaxValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(10000, "Test Product", 100.0m, 10);

            // Act & Assert
            Assert.That(product.ProductID, Is.EqualTo(10000));
        }

        [Test]
        public void ProductName_ValidValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 10);

            // Act & Assert
            Assert.That(product.ProductName, Is.EqualTo("Test Product"));
        }

        [Test]
        public void Price_ValidValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 10);

            // Act & Assert
            Assert.That(product.Price, Is.EqualTo(100.0m));
        }

        [Test]
        public void Price_MinValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "Test Product", 1.0m, 10);

            // Act & Assert
            Assert.That(product.Price, Is.EqualTo(1.0m));
        }

        [Test]
        public void Price_MaxValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "Test Product", 5000.0m, 10);

            // Act & Assert
            Assert.That(product.Price, Is.EqualTo(5000.0m));
        }

        [Test]
        public void Stock_ValidValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 10);

            // Act & Assert
            Assert.That(product.Stock, Is.EqualTo(10));
        }

        [Test]
        public void Stock_MinValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 1);

            // Act & Assert
            Assert.That(product.Stock, Is.EqualTo(1));
        }

        [Test]
        public void Stock_MaxValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 100000);

            // Act & Assert
            Assert.That(product.Stock, Is.EqualTo(100000));
        }

        [Test]
        public void IncreaseStock_IncreasesStockByGivenAmount()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 10);

            // Act
            product.IncreaseStock(5);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(15));
        }

        [Test]
        public void IncreaseStock_MaxBoundary()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 99995);

            // Act
            product.IncreaseStock(5);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(100000));
        }

        [Test]
        public void DecreaseStock_DecreasesStockByGivenAmount()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 10);

            // Act
            product.DecreaseStock(3);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(7));
        }

        [Test]
        public void DecreaseStock_MinBoundary()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 5);

            // Act
            product.DecreaseStock(5);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(0));
        }
    }
}
