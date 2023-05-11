using Microsoft.EntityFrameworkCore;

namespace Project1.Models
{
    public class ApplicationDbContext: DbContext
    {
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Adress> Adresses { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BSC-PG02KEHR\\SQLEXPRESS;DataBase=PizzaOrder;Integrated Security=true;TrustServerCertificate=true");
        }
    }
}
