﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SimpraApi.Base;

public class AuditableEntityConfiguration<TEntity> : BaseEntityConfiguration<TEntity> where TEntity : AuditableEntity
{
    public override void Configure(EntityTypeBuilder<TEntity> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.UpdatedAt).IsRequired(false);
        builder.Property(x => x.UpdatedBy).HasMaxLength(36).IsRequired(false);
    }
}
