using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // Calculates total price (sum of products + shipping)
        public double CalculateTotalPrice()
        {
            double total = 0;
            
            foreach (Product product in _products)
            {
                total += product.GetTotalCost();
            }

            // Shipping cost logic based on customer's location
            double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
            
            return total + shippingCost;
        }

        // Generates the packing label (Product Name - Product ID)
        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- PACKING LABEL ---");
            
            foreach (Product product in _products)
            {
                sb.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
            }
            
            return sb.ToString();
        }

        // Generates the shipping label (Customer Name & Address)
        public string GetShippingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- SHIPPING LABEL ---");
            sb.AppendLine(_customer.GetName());
            sb.AppendLine(_customer.GetAddress().GetFullAddress());
            
            return sb.ToString();
        }
    }
}