using System.ComponentModel.DataAnnotations;
using JustinWritesCode.EntityFrameworkCore.Abstractions;
namespace JustinWritesCode.EntityFrameworkCore;

/// <summary>
/// <inheritdoc cref="ITimestamp"/>
/// </summary>
public struct Timestamp : ITimestamp
{
    public Timestamp()
    {
        By = default;
        When = DateTimeOffset.UtcNow;
        Details = new StringDictionary();
    }

    public object? By { get; set; }
    [DataType(DataType.DateTime)]
    public DateTimeOffset When { get; set; }
    public IStringDictionary Details { get; set; }
}
