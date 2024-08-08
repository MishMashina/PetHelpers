﻿namespace PetHelpers.Domain.Models;

public abstract class Entity
{
    public Guid Id { get; }
    
    protected Entity() { }

    protected Entity(Guid id) => Id = id;

    public override bool Equals(object? obj)
    {
        if (obj is not Entity other)
            return false;

        if (ReferenceEquals(this, other) == false)
            return false;

        if (GetType() != other.GetType())
            return false;

        return Id == other.Id;
    }
    
    public override int GetHashCode()
        => HashCode.Combine(GetType().ToString() + Id);

    public static bool operator ==(Entity first, Entity second)
    {
        if (ReferenceEquals(first, null) && ReferenceEquals(second, null))
            return true;

        if (ReferenceEquals(first, null) || ReferenceEquals(second, null))
            return false;
        
        return first.Equals(second);
    }

    public static bool operator !=(Entity first, Entity second) 
        => !(first == second);
}