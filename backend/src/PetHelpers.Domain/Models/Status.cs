using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models;

public class Status : ValueObject
{
    public static readonly Status NeedsHelp = new(nameof(NeedsHelp));
    public static readonly Status LookingForHome = new(nameof(LookingForHome));
    public static readonly Status FoundHome = new(nameof(FoundHome));

    private static readonly Status[] _all = [NeedsHelp, LookingForHome, FoundHome];
    
    public string Value { get; }

    private Status(string value)
    {
        Value = value;
    }
    
    private Status()
    {
    }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Value;
    }
}