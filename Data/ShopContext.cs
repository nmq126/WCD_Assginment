using AssignmentWCD.Models;
using System.Data.Entity;

namespace AssignmentWCD.Data
{
    public class ShopContext: DbContext
    {
        public ShopContext() : base("name=AssignmentWCD")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}