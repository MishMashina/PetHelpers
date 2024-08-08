namespace PetHelpers.Domain.Models;

public class Volunteer : Entity
{
    public const int MAX_PHONE_NUMBER_LENGTH = 15;
    
    public const int MAX_FULL_NAME_LENGTH = 100;
    
    public const int MAX_DESCRIPTION_LENGTH = 1000;
    
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

    private Volunteer()
    {
    }
}