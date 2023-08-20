using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps;

public class StudentConfiguration : BaseConfiguration<Student>
{
    public override void Configure(EntityTypeBuilder<Student> builder)
    {
        //many of these configures are applied by convention way,
        //but I want to apply most configures with fluent api and data annotation for exercise

        builder.HasKey(s => s.StudentId);
        builder.Property(s => s.StudentId).ValueGeneratedOnAdd();

        builder.Property(s => s.Name).IsRequired();
        builder.Property(s => s.Family).IsRequired();
        builder.Property(s => s.FatherName).IsRequired();

        builder.HasMany(s => s.Courses)
            .WithMany(c => c.Students);

        base.Configure(builder);
    }
}
