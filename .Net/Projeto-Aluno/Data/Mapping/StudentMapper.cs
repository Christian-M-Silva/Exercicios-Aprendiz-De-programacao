using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping {
    public class StudentMapper : IEntityTypeConfiguration<StudentEntite> {
        public void Configure(EntityTypeBuilder<StudentEntite> builder) {
            
            builder.ToTable("Student");

            builder.HasKey(student => student.Id);

            builder.Property(student => student.Name).HasMaxLength(255).IsRequired();

            builder.Property(student => student.Age).IsRequired();

            builder.Property(student => student.Serie).IsRequired();

            builder.Property(student => student.Responsible).IsRequired().HasMaxLength(255);

            builder.Property(student => student.ResponsibleAlternative).HasMaxLength(255);

            builder.Property(student => student.PhoneNumber).IsRequired();
        }
    }
}
