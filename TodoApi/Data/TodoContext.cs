using Microsoft.EntityFrameworkCore;
using Models;
namespace Data
{
    public class TodoContext : DbContext
    {

        public DbSet<TodoItem> TodoItens { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseSqlServer("Server=DESKTOP-0VIALFL\\SQLEXPRESSS;Database=TodoAppDb;Trusted_Connection=True");

    }

}
