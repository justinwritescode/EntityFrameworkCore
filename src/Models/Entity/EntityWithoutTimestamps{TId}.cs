/*
 * Entity{TId}.cs
 *
 *   Created: 2022-12-28-04:10:43
 *   Modified: 2022-12-30-01:46:30
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.EntityFrameworkCore.Models;

using JustinWritesCode.Abstractions;
using JustinWritesCode.EntityFrameworkCore.Abstractions;

/// <summary>
/// This is an abstract base class for all Entity Framework entities.
/// </summary>
/// <typeparam name="TId">The type of the ID (primary key) property.</typeparam>
public abstract class Entity<TId> : IEntity<TId>, IEntity, IIdentifiable<TId>, IEquatable<IEntity<TId>>, IComparable<IEntity<TId>>, IHaveAWritableId<TId>, IHaveAWritableId
    where TId : IComparable, IEquatable<TId>
{
    public virtual TId Id { get => (TId)((IIdentifiable)this).Id; set => ((IHaveAWritableId)this).Id = value; }
    object IIdentifiable.Id => Id;
    object IHaveAWritableId.Id { get; set; }

    public bool Equals(IEntity? other) => GetHashCode() == other?.GetHashCode();
    public virtual bool Equals(IEntity<TId>? other) => Id.Equals(other == default ? default : (other as IIdentifiable<TId>).Id);
    public virtual int CompareTo(IEntity<TId>? other) => Id.CompareTo(other == default ? default : (other as IIdentifiable<TId>).Id);
    public virtual int CompareTo(IEntity? other) => CompareTo(other == default ? default : other as IEntity<TId>);
    public int CompareTo(object? obj) => obj is IIdentifiable oid ? Id.CompareTo(oid.Id) : throw new ArgumentException($"Object must be of type {nameof(IIdentifiable)}.", nameof(obj));
}
