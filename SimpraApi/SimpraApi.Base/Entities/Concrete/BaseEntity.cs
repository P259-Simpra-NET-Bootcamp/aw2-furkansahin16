﻿namespace SimpraApi.Base;

public abstract class BaseEntity : IEntity, ICreatable
{
    public Guid Id { get; set; }
    public Status Status { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
}
