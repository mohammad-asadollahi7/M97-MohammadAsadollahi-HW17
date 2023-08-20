using Domain;
using Domain.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps;

public class CourseConfiguration : BaseConfiguration<Course>
{
    public override void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(c => c.CourseId);
        builder.Property(c => c.CourseId)
            .ValueGeneratedOnAdd();
        builder.Property(c => c.Name)
            .IsRequired();
        builder.Property(c => c.Unit)
            .IsRequired();

        base.Configure(builder);
    }
}
