

using Domain;
using Domain.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps;

public class StateConfiguration : BaseConfiguration<State>
{
    public override void Configure(EntityTypeBuilder<State> builder)
    {
        builder.HasKey(s => s.StateId);
        builder.Property(s => s.StateId)
            .ValueGeneratedOnAdd();
        builder.Property(s => s.Name)
            .IsRequired();

        base.Configure(builder);
    }
}
