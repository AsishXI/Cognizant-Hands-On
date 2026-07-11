using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using AppDbContext context = new AppDbContext();

Console.WriteLine("Products List:\n");

var products = context.Products
                      .Include(p => p.Category)
                      .ToList();

foreach (var product in products)
{
    Console.WriteLine(
        $"Id: {product.Id}, " +
        $"Name: {product.Name}, " +
        $"Price: {product.Price}, " +
        $"Category: {product.Category?.Name}");
}