using JustinWritesCode.Abstractions;
using JustinWritesCode.EntityFrameworkCore.Abstractions;

namespace JustinWritesCode.EntityFrameworkCore;

public class Entity<TId> : IIdentifiable<TId>
    where TId : IComparable, IEquatable<TId>
{
    public TId Id { get; set; }
}
