namespace SimpraApi.Base;

public class ErrorResponse : CommonResponse
{
    public List<string> Errors { get; set; } = new();
    public ErrorResponse(string message) : base(false, message) { }
    public ErrorResponse() : base(false) { }
}


