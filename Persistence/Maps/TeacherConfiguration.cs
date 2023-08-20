using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps;

public class TeacherConfiguration : BaseConfiguration<Teacher>
{
    public override void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.HasKey(t => t.TeacherId);
        builder.Property(t => t.TeacherId)
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired();
        builder.Property(t => t.Family)
            .IsRequired();

        builder.HasMany(t => t.Courses)
            .WithOne(c => c.Teacher);


        base.Configure(builder);
    }
}
