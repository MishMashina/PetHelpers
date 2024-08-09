using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models;

public class SocialMedia : ValueObject
{ 
    public string Title { get; }
    
    public string Link { get; }

    private SocialMedia(string title, string link)
    {
        Title = title;
        Link = link;
    }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Title;
        yield return Link;
    }
}