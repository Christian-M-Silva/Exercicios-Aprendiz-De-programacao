using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping {
    public class DirectorMapper : IEntityTypeConfiguration<DirectorEntite> {
        public void Configure(EntityTypeBuilder<DirectorEntite> builder) {
            builder.ToTable("Director");

            builder.HasKey(director => director.Id);

            builder.HasIndex(director => director.Email).IsUnique();

            builder.Property(director => director.Name).IsRequired().HasMaxLength(255);

            builder.Property(director => director.Email).IsRequired().HasMaxLength(255);
        }

    }
}
