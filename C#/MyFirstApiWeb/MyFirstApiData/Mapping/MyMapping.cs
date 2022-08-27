using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFirstApiDomain.Entities;

namespace MyFirstApiData.Mapping{
    public class MyMapping : IEntityTypeConfiguration<User>{
        public void Configure(EntityTypeBuilder<User> builder){
            builder.ToTable("User"); //Dar nome a tabela
            builder.HasKey(x => x.Id); //Qual propredade ou coluna será a primary key
            builder.HasIndex(x => x.Email).IsUnique(); //Vai ter um indice de BD e ele vai ser unico
            builder.Property(x => x.Email).HasMaxLength(100); //A propriedade vai ser o varchar de 100
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60); //Aqui vai ser notNull e varchar de 60
        }
    }
}
