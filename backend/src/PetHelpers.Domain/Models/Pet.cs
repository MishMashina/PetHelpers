namespace PetHelpers.Domain.Models;

public class Pet
{
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
    
    public List<PetPhoto> Photos { get;  }
}