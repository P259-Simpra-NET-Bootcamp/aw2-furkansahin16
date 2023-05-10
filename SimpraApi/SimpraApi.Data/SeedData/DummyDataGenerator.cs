using Bogus;

namespace SimpraApi.Data.SeedData;

public static class DummyDataGenerator
{
    public static IEnumerable<Staff> GenerateDummyData(int dataCount)
    {
        var faker = new Faker<Staff>()
            .Ignore(x => x.CreatedAt)
            .Ignore(x => x.CreatedBy)
            .Ignore(x => x.DeletedBy)
            .Ignore(x => x.DeletedAt)
            .Ignore(x => x.UpdatedAt)
            .Ignore(x => x.UpdatedBy)
            .RuleFor(x => x.Id, s => s.UniqueIndex)
            .RuleFor(x => x.FirstName, s => s.Person.FirstName)
            .RuleFor(x => x.LastName, s => s.Person.LastName)
            .RuleFor(x => x.Email, s => s.Person.Email)
            .RuleFor(x => x.Phone, s => s.Person.Phone)
            .RuleFor(x => x.DateOfBirth, s => s.Person.DateOfBirth)
            .RuleFor(x => x.AddressLine, s => s.Address.StreetAddress())
            .RuleFor(x => x.City, s => s.Address.City())
            .RuleFor(x => x.Country, s => s.Address.Country())
            .RuleFor(x => x.Province, s => s.Address.State());

        var dummyData = faker.Generate(dataCount);
        return dummyData;
    }
}
