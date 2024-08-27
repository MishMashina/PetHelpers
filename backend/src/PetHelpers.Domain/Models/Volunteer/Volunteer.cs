using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models.Volunteer;

public class Volunteer : Entity<Guid>
{
    private readonly List<SocialMedia> _socialMedias = [];
    private readonly List<Requisite> _requisites = [];
    private readonly List<Pet> _ownedPets = [];
    
    private Volunteer(string description, int petsInTreatment, int petsLookingForHome, int petsFoundHome, int yearsOfExperience, 
        PhoneNumber phoneNumber, FullName fullName)
    {
        Description = description;
        PetsInTreatment = petsInTreatment;
        PetsLookingForHome = petsLookingForHome;
        PetsFoundHome = petsFoundHome;
        YearsOfExperience = yearsOfExperience;
        PhoneNumber = phoneNumber;
        FullName = fullName;
    }

    public IReadOnlyList<SocialMedia> SocialMedias => _socialMedias;
    public IReadOnlyList<Requisite> Requisites => _requisites;
    public IReadOnlyList<Pet> OwnedPets => _ownedPets;
    public FullName FullName { get; private set; }
    public PhoneNumber PhoneNumber { get; private set; }
    public int YearsOfExperience { get; private set; }
    public int PetsFoundHome { get; private set; }
    public int PetsLookingForHome { get; private set; }
    public int PetsInTreatment { get; private set; }
    public string Description { get; private set; }

    public static Result<Volunteer, string> Create(string description, int petsInTreatment, int petsLookingForHome,
        int petsFoundHome, int yearsOfExperience, PhoneNumber phoneNumber, FullName fullName)
    {
        //всякие проверки IsNullOrWhiteSpace || констрейнт и все такое 

        var volunteer = new Volunteer(description, petsInTreatment, petsLookingForHome, petsFoundHome,
            yearsOfExperience, phoneNumber, fullName);
        
        return Result.Success<Volunteer, string>(volunteer);
    }
}