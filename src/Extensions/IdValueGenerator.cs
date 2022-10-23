namespace JustinWritesCode.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

public class IdValueGenerator : ValueGenerator
{
    public override bool GeneratesTemporaryValues => false;

    protected override object? NextValue(EntityEntry entry)
    {
        var idProperty = entry.Property("Id");
        var _type = idProperty.Metadata.ClrType;
        return _type.Name switch
        {
            nameof(System.Byte) => RandomByte(),
            nameof(System.SByte) => RandomSByte(),
            nameof(System.Int16) => RandomLong(1000, 10000000),
            nameof(System.UInt16) => RandomULong(1000, 10000000),
            nameof(System.Int32) => RandomInt(1000, 10000000),
            nameof(System.UInt32) => RandomUInt(1000, 10000000),
            nameof(System.Int64) => RandomLong(1000, 10000000),
            nameof(System.UInt64) => RandomULong(1000, 10000000),
            nameof(System.String) => Guid.NewGuid().ToString(),
            _ => Guid.NewGuid()
        };
    }
}
