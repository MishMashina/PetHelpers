using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models.Scepies;

public class Breed : Entity<Guid>
{
    private Breed() { }
    
    public string Title { get; private set; }
}