namespace JustinWritesCode.EntityFrameworkCore.Extensions;
using static JustinWritesCode.Types.Extensions.RandomV2;
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
            nameof(System.Byte) => RandomUInt8(),
            nameof(System.SByte) => RandomInt8(),
            nameof(System.Int16) => RandomInt16(1000, 10000000),
            nameof(System.UInt16) => RandomUInt16(1000, 10000000),
            nameof(System.Int32) => RandomInt32(1000, 10000000),
            nameof(System.UInt32) => RandomUInt32(1000, 10000000),
            nameof(System.Int64) => RandomInt64(1000, 10000000),
            nameof(System.UInt64) => RandomUInt64(1000, 10000000),
            nameof(System.String) => Guid.NewGuid().ToString(),
            _ => Guid.NewGuid()
        };
    }
}
