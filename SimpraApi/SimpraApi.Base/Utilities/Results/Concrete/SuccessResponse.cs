namespace SimpraApi.Base;
public class SuccessResponse : CommonResponse
{
    public SuccessResponse(string message) : base(true, message) { }
    public SuccessResponse() : base(true) { }
}


