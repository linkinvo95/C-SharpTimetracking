using System;

namespace BusinessEntities
{
    public class OrderItem : IdObject
    {
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public void Set(Product product, int quantity)
        {
            if (product == null)
            {
                throw new ArgumentNullException("The product was not proided.");
            }
            if (!product.HasAvailableQuantity(quantity))
            {
                throw new Exception("The product quantity is unavailable");
            }
            product.AdjustQuantity(-1 * quantity);
            Product = product;
            Quantity = quantity;
            Price = product.Price;
        }

        public decimal GetTotal() => Quantity * Price;
    }
}