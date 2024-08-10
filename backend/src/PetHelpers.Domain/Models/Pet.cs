using CSharpFunctionalExtensions;

namespace PetHelpers.Domain.Models;

public class Pet : Entity<Guid>
{
    public Guid SpeciesID { get; }

    public string BreedName { get; set; }
    
    public string Name { get; }
    
    public string Description { get; }
    
    public string Color { get; }
    
    public string HealthInfo { get; }
    
    public string Location { get; }
    
    public PhoneNumber OwnersPhoneNumber { get; }
    
    public double Weight { get; }
    
    public double Height { get; }
    
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