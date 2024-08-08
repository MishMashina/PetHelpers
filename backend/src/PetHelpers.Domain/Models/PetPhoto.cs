namespace PetHelpers.Domain.Models;

public class PetPhoto : Entity
{
    public const int MAX_PATH_LENGTH = 256;

    public bool IsMain { get; }
    
    public string Path { get; }
    
    private PetPhoto()
    {
    }
}