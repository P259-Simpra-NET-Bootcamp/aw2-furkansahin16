using SimpraApi.Base;

namespace SimpraApi.Schema;
public class StaffRequest : BaseRequest
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public string? AddressLine1 { get; set; }
    public string? City { get; set; }
    public string Country { get; set; } = null!; 
    public string? Province { get; set; }
}
