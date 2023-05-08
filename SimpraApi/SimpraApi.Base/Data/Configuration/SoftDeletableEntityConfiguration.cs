using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SimpraApi.Base;

public class SoftDeletableEntityConfiguration<TEntity> : AuditableEntityConfiguration<TEntity> where TEntity : SoftDeletableEntity
{
    public override void Configure(EntityTypeBuilder<TEntity> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.DeletedAt).IsRequired(false);
        builder.Property(x => x.DeletedBy).HasMaxLength(36).IsRequired(false);
    }
}
