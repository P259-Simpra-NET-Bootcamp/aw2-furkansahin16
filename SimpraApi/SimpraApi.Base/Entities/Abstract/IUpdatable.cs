namespace SimpraApi.Base;

public interface IUpdatable : IEntity
{
    string? UpdatedBy { get; set; }
    DateTime DeletedAt { get; set; }
}
