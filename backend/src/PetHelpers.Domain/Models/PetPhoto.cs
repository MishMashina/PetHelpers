namespace PetHelpers.Domain.Models;

public class PetPhoto
{
    public Guid Id { get; }

    public bool IsMain { get; }
    
    public string Path { get; }
}