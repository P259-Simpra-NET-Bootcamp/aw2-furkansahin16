using SimpraApi.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpraApi.Domain;

public class Staff : BaseEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? AddressLine { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? Province { get; set; }
    [NotMapped] public string? FullName => $"{FirstName} {LastName}";

}
