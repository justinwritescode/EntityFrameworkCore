namespace JustinWritesCode.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore;


/// <summary>
/// Interface for a database context.  Implements all public properties and methods of <see cref="DbContext"/>.
/// </summary>[ProxyInterfaceGenerator.Proxy(typeof(DbContext))]
public partial interface IDbContext
{
}

/// <summary>
/// Interface for a database context.  Implements all public properties and methods of <see cref="DbContext"/>.
/// </summary>
public interface IDbContext<TContext> : IDbContext where TContext : DbContext
{
}
