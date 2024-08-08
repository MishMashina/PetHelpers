namespace PetHelpers.Domain.Models;

public class Volunteer
{
    public Guid Id { get; } 
    
    public string FullName { get; }
    
    public string Description { get; }
    
    public string PhoneNumber { get; }

    public int YearsOfExperience { get; }
    
    public int PetsFoundHome { get; }
    
    public int PetsLookingForHome { get; }
    
    public int PetsInTreatment { get; }

    public List<SocialMedia> SocialMedias { get; }
    
    public List<Requisite> Requisites  { get; }

    public List<Pet> OwnedPets { get; }
}

public class SocialMedia
{
    public string Title { get; }
    
    public string Link { get; }
}