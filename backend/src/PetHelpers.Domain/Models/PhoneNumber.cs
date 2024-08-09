using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models;

public class PhoneNumber : ValueObject
{
    public string Number { get; }
    
    private PhoneNumber(string number)
    {
        Number = number;
    }
    
    private PhoneNumber()
    {
    }
    
    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Number;
    }
}