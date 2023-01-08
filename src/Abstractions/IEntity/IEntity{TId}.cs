/*
 * IEntity.cs
 *
 *   Created: 2023-01-03-12:27:21
 *   Modified: 2023-01-03-12:27:22
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace  JustinWritesCode.EntityFrameworkCore.Abstractions;

/// <summary>A base interface for database entities with a strongly-typed <see cref="IIdentifiable{TId}.Id" /> property.</summary>
public interface IEntity<TId> : IIdentifiable<TId> where TId : IComparable, IEquatable<TId>
{

}
