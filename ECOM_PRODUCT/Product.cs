using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOM_PRODUCT
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string productName, decimal price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int amount)
        {
            if (Stock + amount > 100000)
                throw new ArgumentOutOfRangeException(nameof(amount), "Stock cannot exceed 100000.");
            Stock += amount;
        }

        public void DecreaseStock(int amount)
        {
            if (Stock - amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Stock cannot be less than 0.");
            Stock -= amount;
        }
    }
}
