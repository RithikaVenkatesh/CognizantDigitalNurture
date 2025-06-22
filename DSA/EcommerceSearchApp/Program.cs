using System;
using EcommerceSearchApp;

namespace EcommerceSearchApp
{
    class Program
    {
        public static Product? LinearSearch(Product[] products, string productName)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }

        public static Product? BinarySearch(Product[] products, string productName)
        {
            int left = 0, right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int result = string.Compare(products[mid].ProductName, productName, StringComparison.OrdinalIgnoreCase);

                if (result == 0)
                    return products[mid];
                else if (result < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }

        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Shoes", "Fashion"),
                new Product(103, "Mobile", "Electronics"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Bag", "Fashion")
            };

            Console.WriteLine("Enter product name to search:");
            string? searchTerm = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                Console.WriteLine("Invalid product name.");
                return;
            }

            Console.WriteLine("\n--- Linear Search ---");
            var found1 = LinearSearch(products, searchTerm);
            Console.WriteLine(found1 != null ? $"Found: {found1.ProductName} ({found1.Category})" : "Product not found!");

            Array.Sort(products, (a, b) => string.Compare(a.ProductName, b.ProductName));

            Console.WriteLine("\n--- Binary Search ---");
            var found2 = BinarySearch(products, searchTerm);
            Console.WriteLine(found2 != null ? $"Found: {found2.ProductName} ({found2.Category})" : "Product not found!");
        }
    }
}
