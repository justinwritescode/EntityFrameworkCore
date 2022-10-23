namespace JustinWritesCode.EntityFrameworkCore.Abstractions;

/// <summary>
/// A timestamp for something happening in the database, including rowversion, a dictionary of details, and the ID of the user who made the change.
/// </summary>
public interface ITimestamp
{
    /// <value>The ID of the user who made the change</value>
    object? By { get; set; }
    /// <value>The <see cref="DateTime"/> of the change</value>
    DateTime When { get; set; }
    /// <value>An <see cref="IDictionary{string, object}"/> of the details of the change (if any)</value>
    IDictionary<string, object> Details { get; set; }
    /// <value>The ROWVERSION/TIMESTAMP of the change (if any)</value>
    byte[] Version { get; set; }
}
