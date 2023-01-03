/*
 * IEntity{TId}.cs
 *
 *   Created: 2022-10-23-04:33:44
 *   Modified: 2022-11-12-09:06:39
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.EntityFrameworkCore.Abstractions;
using JustinWritesCode.Abstractions;
    /// <inheritdoc cref="ITimestampedTimestampedEntity" />
    /// <typeparam name="TId"><inheritdoc cref="IEntityWithoutTimestamps{TId}"/></typeparam>
    public interface ITimestampedEntity<TId> : IEntityWithoutTimestamps<TId>, ITimestampedEntity where TId : IComparable, IEquatable<TId>
{
}
