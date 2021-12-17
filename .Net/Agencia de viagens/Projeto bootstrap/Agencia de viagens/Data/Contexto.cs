using Agencia_de_viagens.Models;
using Microsoft.EntityFrameworkCore;

namespace Agencia_de_viagens.Data{
    public class Contexto : DbContext {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-GI8KG8T; Initial Catalog=Agencia; User Id =sa; Password =13072001cms; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Cliente>(table =>
            {
                table.ToTable("Clientes");
                table.HasKey(prop => prop.Id);

                table.Property(prop => prop.Nome).HasMaxLength(48).IsRequired ();
                table.Property(prop => prop.Cpf).HasColumnType("char(11)").IsRequired();
                table.Property(prop => prop.DataNascimento).HasColumnType("date");
                table.Property(prop => prop.Situacao).HasConversion<string>().HasMaxLength(9);
            });
        }
    }
}
