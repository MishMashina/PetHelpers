namespace PetHelpers.Domain.Models;

public class Pet
{
    public const int MAX_OWNERS_PHONE_NUMBER_LENGTH = 15;
    
    public const int MAX_NAME_LENGTH = 100;
    
    public const int MAX_SPECIES_LENGTH = 100;
    
    public const int MAX_COLOR_LENGTH = 100;
    
    public const int MAX_LOCATION_LENGTH = 300;

    public const int MAX_DESCRIPTION_LENGTH = 1000;

    public const int MAX_HEALTH_INFO_LENGTH = 1000;
    
    public Guid Id { get; } 
    
    public Guid VolunteerId { get; }
    
    public string Name { get; }
    
    public string Species { get; }
    
    public string Description { get; }
    
    public string Color { get; }
    
    public string HealthInfo { get; }
    
    public string Location { get; }
    
    public string OwnersPhoneNumber { get; }
    
    public int Weight { get; }
    
    public int Height { get; }
    
    public bool IsCastrated { get; }    
    
    public bool IsVaccinated { get; }
    
    public DateOnly Birthdate { get; }    
    
    public DateTime CreationDate { get; } 
    
    public Status HelpStatus { get; }

    public List<Requisite> Requisites  { get; }
    
    public List<PetPhoto> Photos { get; }

    private Pet()
    {
    }
}