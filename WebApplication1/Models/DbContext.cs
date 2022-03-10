using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
}

public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int Id { get; set; }
}