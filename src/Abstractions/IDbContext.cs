//
// IDbContext.cs
//
//   Created: 2022-10-18-10:51:12
//   Modified: 2022-11-13-01:18:19
//
//   Author: Justin Chase <justin@justinwritescode.com>
//
//   Copyright © 2022 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//

namespace JustinWritesCode.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore;


/// <summary>
/// Interface for a database context.  Implements all public properties and methods of <see cref="DbContext"/>.
/// </summary>
[ProxyInterfaceGenerator.Proxy(typeof(Microsoft.EntityFrameworkCore.DbContext))]
public partial interface IDbContext
{
}

/// <summary>
/// Interface for a database context.  Implements all public properties and methods of <see cref="DbContext"/>.
/// </summary>
public interface IDbContext<TSelf> : IDbContext where TSelf : DbContext
{
}
