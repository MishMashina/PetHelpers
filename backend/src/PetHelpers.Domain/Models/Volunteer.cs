using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models;

public class Volunteer : Entity<Guid>
{ 
    public FullName FullName { get; }
    
    public string Description { get; }
    
    public PhoneNumber PhoneNumber { get; }

    public int YearsOfExperience { get; }
    
    public int PetsFoundHome { get; }
    
    public int PetsLookingForHome { get; }
    
    public int PetsInTreatment { get; }

    public List<SocialMedia> SocialMedias { get; }
    
    public List<Requisite> Requisites  { get; }

    public List<Pet> OwnedPets { get; }

    private Volunteer()
    {
    }
}