/*
 * IAuthorizableEntity.cs
 *
 *   Created: 2023-01-03-12:29:17
 *   Modified: 2023-01-03-12:29:17
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.EntityFrameworkCore.Abstractions;

using System.Security.Claims;

public interface IAuthorizableEntity : IEntity
{
    bool CanDo(ClaimsPrincipal principal, string operation);

    #if NET6_0_OR_GREATER
    bool CanRead(ClaimsPrincipal principal) => CanDo(principal, JustinWritesCode.Security.Operations.Read.Name);
    bool CanUpdate(ClaimsPrincipal principal) => CanDo(principal, JustinWritesCode.Security.Operations.Update.Name);
    bool CanDelete(ClaimsPrincipal principal) => CanDo(principal, JustinWritesCode.Security.Operations.Delete.Name);
    bool CanCreate(ClaimsPrincipal principal) => CanDo(principal, JustinWritesCode.Security.Operations.Create.Name);
    #else
    bool CanRead(ClaimsPrincipal principal);
    bool CanUpdate(ClaimsPrincipal principal);
    bool CanDelete(ClaimsPrincipal principal);
    bool CanCreate(ClaimsPrincipal principal);
    #endif
}
