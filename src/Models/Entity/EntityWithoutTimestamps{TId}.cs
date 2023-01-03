/*
 * EntityWithoutTimestamps{TId}.cs
 *
 *   Created: 2022-12-28-04:10:43
 *   Modified: 2022-12-30-01:46:30
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.EntityFrameworkCore.Models;

using System.Runtime.InteropServices.ComTypes;
using JustinWritesCode.Abstractions;
using JustinWritesCode.EntityFrameworkCore.Abstractions;

/// <summary>
/// This is an abstract base class for all Entity Framework entities.
/// </summary>
/// <typeparam name="TId">The type of the ID (primary key) property.</typeparam>
public abstract class EntityWithoutTimestamps<TId> : IEntityWithoutTimestamps<TId>, IEntityWithoutTimestamps, IIdentifiable<TId>, IEquatable<IEntityWithoutTimestamps<TId>>, IComparable<IEntityWithoutTimestamps<TId>>, IHaveAWritableId<TId>, IHaveAWritableId
    where TId : IComparable, IEquatable<TId>
{
    public virtual TId Id { get => (TId)((IIdentifiable)this).Id; set => ((IHaveAWritableId)this).Id = value; }
    object IIdentifiable.Id => Id;
    object IHaveAWritableId.Id { get; set; }

    public bool Equals(IEntityWithoutTimestamps? other) => GetHashCode() == other?.GetHashCode();
    public virtual bool Equals(IEntityWithoutTimestamps<TId>? other) => Id.Equals(other == default ? default : (other as IIdentifiable<TId>).Id);
    public virtual int CompareTo(IEntityWithoutTimestamps<TId>? other) => Id.CompareTo(other == default ? default : (other as IIdentifiable<TId>).Id);
    public virtual int CompareTo(IEntityWithoutTimestamps? other) => CompareTo(other == default ? default : other as IEntityWithoutTimestamps<TId>);
    public int CompareTo(object? obj) => obj is IIdentifiable oid ? Id.CompareTo(oid.Id) : throw new ArgumentException($"Object must be of type {nameof(IIdentifiable)}.", nameof(obj));
}
