using Data.Mapping;
using Domain.Entites;
using Microsoft.EntityFrameworkCore;


namespace Data.Context {
    public class MyContext:DbContext {

        public DbSet<StudentEntite> Student { get; set; }

        public DbSet<DirectorEntite> Director { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentEntite> (new StudentMapper().Configure);
            modelBuilder.Entity<DirectorEntite> (new DirectorMapper().Configure);
        }

    }
}
