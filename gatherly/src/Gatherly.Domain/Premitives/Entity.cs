﻿namespace Gatherly.Domain.Premitives;

public abstract class Entity : IEquatable<Entity>
{
    protected Entity(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; private init; }

    public static bool operator ==(Entity? first, Entity? second)
    {
        return first is not null
               && second is not null
               && first.Equals(second);
    }

    public static bool operator !=(Entity? first, Entity? second) => !(first == second);

    public bool Equals(Entity? other)
    {
        if (other is null) return false;

        if (other.GetType() != GetType()) return false;

        return other.Id == Id;
    }

    public override bool Equals(object? obj) => obj is Entity && Equals(obj);

    public override int GetHashCode() => Id.GetHashCode() * 961;
}