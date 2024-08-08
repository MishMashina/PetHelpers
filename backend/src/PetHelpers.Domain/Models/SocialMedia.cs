namespace PetHelpers.Domain.Models;

public class SocialMedia : Entity
{
    public const int MAX_TITLE_LENGTH = 50;
    
    public const int MAX_LINK_LENGTH = 500;
    
    public string Title { get; }
    
    public string Link { get; }

    private SocialMedia()
    {
    }
}