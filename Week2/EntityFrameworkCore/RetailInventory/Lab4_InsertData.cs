using RetailInventory.Data;
using RetailInventory.Models;

using AppDbContext context = new AppDbContext();

// Insert categories
if (!context.Categories.Any())
{
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    context.Categories.AddRange(electronics, groceries);
    context.SaveChanges();

    // Insert products
    context.Products.AddRange(
        new Product
        {
            Name = "Laptop",
            Price = 65000,
            CategoryId = electronics.Id
        },
        new Product
        {
            Name = "Mobile",
            Price = 25000,
            CategoryId = electronics.Id
        },
        new Product
        {
            Name = "Rice",
            Price = 60,
            CategoryId = groceries.Id
        });

    context.SaveChanges();

    Console.WriteLine("Sample data inserted successfully.");
}
else
{
    Console.WriteLine("Data already exists.");
}