using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps;

public class AddressConfiguration : BaseConfiguration<Address>
{
    public override void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(a => a.AddressId);
        builder.Property(a => a.AddressId)
            .ValueGeneratedOnAdd();
        builder.Property(a => a.Description)
            .IsRequired();
        builder.HasIndex(a => a.StudentId)
            .IsUnique();
        builder.Property(a => a.StudentId)
            .IsRequired();
        builder.Property(a => a.StateId)
            .IsRequired();

        base.Configure(builder);
    }
}
