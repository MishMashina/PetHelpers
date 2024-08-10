using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models.Volunteer;

public class PetPhoto : Entity<Guid>
{
    private PetPhoto() { }
    
    public bool IsMain { get; private set; }
    public string Path { get; private set; }
}