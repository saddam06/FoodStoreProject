using Microsoft.EntityFrameworkCore;
using FoodStore.Models;

namespace FoodStore.Data
{
    public class ApplicationDbContexts:DbContext
    {
        
        public ApplicationDbContexts(DbContextOptions<ApplicationDbContexts> options) 
            :base(options) { }
        
        public DbSet<FoodStore.Models.Category> Category { get; set; }
        
        public DbSet<FoodStore.Models.Product> Product { get; set; }
        
        public DbSet<FoodStore.Models.Order> Order { get; set; }
        
        public DbSet<FoodStore.Models.User> User { get; set; }

        



    }
}
