namespace SimpraApi.Base;

public interface IEntity
{
    Guid Id { get; set; }
    Status Status { get; set; }
}
