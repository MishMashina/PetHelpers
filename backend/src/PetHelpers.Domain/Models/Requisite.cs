namespace PetHelpers.Domain.Models;

public class Requisite : Entity
{
    public const int MAX_TITLE_LENGTH = 1000;
    
    public const int MAX_DESCRIPTION_LENGTH = 1000;
    
    public string Title { get; }
    
    public string Description { get; }

    private Requisite()
    {
    }
}