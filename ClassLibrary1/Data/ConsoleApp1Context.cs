using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.Data
{
    public class ConsoleApp1Context : DbContext
    {
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderDetail>? OrderDetails { get; set; }

        public ConsoleApp1Context(DbContextOptions<ConsoleApp1Context> option) : base(option)
        {
        }
    }
}
