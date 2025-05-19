using Microsoft.EntityFrameworkCore;

namespace TestingBlazer
{
    [PrimaryKey(nameof(productid))]
    public class Product
    {
        public int productid { get; set; }
        public string? productname { get; set; }
        public float price { get; set; }
    }
    public class ProductContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=sales.db");
    }

}
