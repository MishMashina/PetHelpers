namespace PetHelpers.Domain.Models;

public class Pet
{
    public Guid Id { get; }
    
    public string Name { get; }
    
    public string Species { get; }
    
    public string Description { get; }
    
    public string Color { get; }
    
    public string HealthInfo { get; }
    
    public string Location { get; }
    
    public int Weight { get; }
    
    public int Height { get; }
    
    public string OwnersPhoneNumber { get; }
    
    public bool Castrated { get; }
    
    public DateOnly Birthdate { get; }
    
    public bool Vaccinated { get; }
    
    public Guid VolunteerId { get; }
    
    public Status HelpStatus { get; }

    public List<Requisite> Requisites  { get; }
    
    public DateTime CreationDate { get; } 
}