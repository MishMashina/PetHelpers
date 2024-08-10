using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models;

public class Breed : Entity<Guid>
{
    public string Title { get; }
    
    public Breed()
    {
    }
}