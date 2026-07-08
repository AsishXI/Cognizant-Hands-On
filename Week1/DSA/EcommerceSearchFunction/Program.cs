using System;

namespace EcommerceSearchFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Phone", "Electronics"),
                new Product(103, "Shoes", "Fashion"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Book", "Education")
            };

            Console.WriteLine("Linear Search:");

            Product linearResult = SearchOperations.LinearSearch(products, 103);

            if (linearResult != null)
            {
                Console.WriteLine($"Product Found: {linearResult.ProductName} ({linearResult.Category})");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            Console.WriteLine();

            Console.WriteLine("Binary Search:");

            Product binaryResult = SearchOperations.BinarySearch(products, 103);

            if (binaryResult != null)
            {
                Console.WriteLine($"Product Found: {binaryResult.ProductName} ({binaryResult.Category})");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}