using Microsoft.EntityFrameworkCore;
using MyFirstApiData.Mapping;
using MyFirstApiDomain.Entities;

namespace MyFirstApiData.Context{
    public class MyContext : DbContext{
        public DbSet<User> Users { get; set; }

        public MyContext (DbContextOptions<MyContext> options) : base (options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User> (new MyMapping().Configure);
        }
    }
}
