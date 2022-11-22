// 
// IEntityWithoutTimestamps{TId}.cs
// 
//   Created: 2022-10-23-04:33:44
//   Modified: 2022-11-13-01:17:17
// 
//   Author: Justin Chase <justin@justinwritescode.com>
//   
//   Copyright © 2022 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
// 


namespace JustinWritesCode.EntityFrameworkCore.Abstractions;
using JustinWritesCode.Abstractions;
    /// <summary>
    /// <inheritdoc  cref="IEntityWithoutTimestamps" />
    /// </summary>
    /// <typeparam name="TId">The type of the entity's primary key (named "<see cref="IHaveAnId{TId}.Id"/>")</typeparam>
    public interface IEntityWithoutTimestamps<TId> : IEntityWithoutTimestamps, IIdentifiable<TId>, IEquatable<IEntityWithoutTimestamps>, IComparable<IEntityWithoutTimestamps>, IComparable
         where TId : IComparable, IEquatable<TId>
    {

}
