using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models;

public class PetPhoto : Entity<Guid>
{
    public bool IsMain { get; }
    
    public string Path { get; }
    
    private PetPhoto()
    {
    }
}