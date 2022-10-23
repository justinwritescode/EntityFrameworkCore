namespace JustinWritesCode.EntityFrameworkCore.Abstractions;

/// <summary>
/// <inheritdoc cref="IHaveADbContext" />
/// </summary>
/// <typeparam name="TContext">The type of the database context</typeparam>
public interface IHaveADbContext<out TContext> : IHaveADbContext where TContext : IDbContext
{
    new TContext Db { get; }
}
