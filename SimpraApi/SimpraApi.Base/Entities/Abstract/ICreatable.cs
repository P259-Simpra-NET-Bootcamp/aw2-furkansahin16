namespace SimpraApi.Base;

public interface ICreatable : IEntity
{
    string? CreatedBy { get; set; }
    DateTime CreatedDate { get; set; }
}
