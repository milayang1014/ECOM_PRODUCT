using NUnit.Framework;
using ECOM_PRODUCT; // Add this line to reference the namespace where Product class is located
using System; // Add this line to include the System namespace

namespace ECOM_PRODUCT_Tests
{
    [TestFixture]
    public class ProductTests
    {
        // Unit tests for the ProductID property
        [Test]
        public void ProductID_ValidValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(5000, "Test Product", 100.0m, 10);

            // Act & Assert
            Assert.That(product.ProductID, Is.EqualTo(5000));
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

        // Unit tests for the ProductName property
        [Test]
        public void ProductName_ValidValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 10);

            // Act & Assert
            Assert.That(product.ProductName, Is.EqualTo("Test Product"));
        }

        [Test]
        public void ProductName_EmptyValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "", 100.0m, 10);

            // Act & Assert
            Assert.That(product.ProductName, Is.EqualTo(""));
        }

        [Test]
        public void ProductName_MaxLengthValue_SetsCorrectly()
        {
            // Arrange
            var productName = new string('A', 100); // Assuming 100 is the max length
            var product = new Product(1, productName, 100.0m, 10);

            // Act & Assert
            Assert.That(product.ProductName, Is.EqualTo(productName));
        }

        // Unit tests for the Price property
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

        // Unit tests for the Stock property
        [Test]
        public void Stock_ValidValue_SetsCorrectly()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 50000);

            // Act & Assert
            Assert.That(product.Stock, Is.EqualTo(50000));
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

        // Unit tests for the IncreaseStock method
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
        public void IncreaseStock_ExceedsMaxValue_ThrowsException()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 99999);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => product.IncreaseStock(2));
        }

        // Unit tests for the DecreaseStock method
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

        [Test]
        public void DecreaseStock_NegativeValue_ThrowsException()
        {
            // Arrange
            var product = new Product(1, "Test Product", 100.0m, 1);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => product.DecreaseStock(2));
        }
    }
}
