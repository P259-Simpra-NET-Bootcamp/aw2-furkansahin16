namespace SimpraApi.Base;

public abstract class BaseEntity : IEntity, ICreatable, IUpdatable, ISoftDeletable
{
    public Guid Id { get; set; }
    public Status Status { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime DeletedAt { get; set; }
    public string? DeletedBy { get; set; }
}
