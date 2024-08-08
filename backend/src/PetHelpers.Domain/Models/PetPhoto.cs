namespace PetHelpers.Domain.Models;

public class PetPhoto
{
    public Guid Id { get; }

    public bool IsMain { get; set; }
    
    public string Path { get; }
}