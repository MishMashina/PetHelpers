namespace PetHelpers.Domain.Models;

public abstract class Entity
{
    public Guid Id { get; }

    public override bool Equals(object obj)
        => ReferenceEquals(this, obj) && Id == ((Entity)obj).Id;

    public override int GetHashCode()
        => HashCode.Combine(Id);

    public static bool operator ==(Entity a, Entity b) => a.Equals(b);

    public static bool operator !=(Entity a, Entity b) => !a.Equals(b);
}