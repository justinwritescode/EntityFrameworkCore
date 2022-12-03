namespace JustinWritesCode.EntityFrameworkCore.Abstractions;

/// <summary>
/// Interface for a class that has a database context as a property
/// </summary>
public interface IHaveADbContext
{
    DbContext Db { get; }
}
