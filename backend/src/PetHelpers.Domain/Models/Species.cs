using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models;

public class Species : Entity<Guid>
{
    public string Title { get; }
    public List<Breed> Breeds { get; }

    private Species()
    {
    }
}