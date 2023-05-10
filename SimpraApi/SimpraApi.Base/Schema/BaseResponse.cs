namespace SimpraApi.Base;
public abstract class BaseResponse
{
    public int Id { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public string Status { get; set; } = null!;
}
