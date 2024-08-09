using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models;

public class Requisite : ValueObject
{ 
    public string Title { get; }
    
    public string Description { get; }

    private Requisite(string title, string description)
    {
        Title = title;
        Description = description;
    }

    private Requisite()
    {
    }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Title;
        yield return Description;
    }
}