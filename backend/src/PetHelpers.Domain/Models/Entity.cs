namespace PetHelpers.Domain.Models;

public abstract class Entity
{
    public Guid Id { get; }

    public override bool Equals(object? obj)
        => Equals(obj as Entity);

    private bool Equals(Entity? entity)
        => entity is not null && Equals(Id, entity.Id);
    
    public override int GetHashCode()
        => HashCode.Combine(Id);

    public static bool operator ==(Entity a, Entity b) => a.Equals(b);

    public static bool operator !=(Entity a, Entity b) => !a.Equals(b);
}