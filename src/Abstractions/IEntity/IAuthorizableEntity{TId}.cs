/*
 * IAuthorizableEntity{TId}.cs
 *
 *   Created: 2023-01-03-12:29:51
 *   Modified: 2023-01-03-12:29:52
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.EntityFrameworkCore.Abstractions;

using System.Security.Claims;

public interface IAuthorizableEntity<TId> : IEntity<TId>, IAuthorizableEntity where TId : IComparable, IEquatable<TId>
{
    bool CanDo(ClaimsPrincipal user, string action);
}
