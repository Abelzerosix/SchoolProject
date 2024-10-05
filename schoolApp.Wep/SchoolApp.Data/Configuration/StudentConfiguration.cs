using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolApp.Data.Models;

namespace SchoolApp.Data.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(s => s.FirstName)
                .IsRequired().HasMaxLength(NameMaxLrnght);

            builder.Property(s => s.LastName)
                   .IsRequired();

            builder.HasOne(s => s.Class)
                   .WithMany(c => c.Students)
                   .HasForeignKey(s => s.ClassId);
        }
    }
}
