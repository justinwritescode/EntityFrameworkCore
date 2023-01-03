namespace JustinWritesCode.EntityFrameworkCore.Constants;

public static partial class DbTypeNames
{
    public const string DbTypeBigInt = "bigint";
    public const string DbTypeInt = "int";
    public const string DbTypeByte = "byte";
    public const string DbTypeVarChar = "varchar";
    public const string DbTypeNVarChar = "nvarchar";
    public const string DbTypeNChar = "nchar";
    public const string DbTypeChar = "char";
    public const string DbTypeTinyInt = "tinyint";
    public const string DbTypeRowVersion = "rowversion";
    public const string DbTypeDateTime = "datetime";
}


[GenerateEnumerationRecordStruct("DbTypeName", "JustinWritesCode.EntityFrameworkCore.Constants")]
public enum DbTypeNameEnum
{
    DbTypeBigInt,
    DbTypeInt,
    DbTypeByte,
    DbTypeVarChar,
    DbTypeNVarChar,
    DbTypeNChar,
    DbTypeChar,
    DbTypeTinyInt,
    DbTypeRowVersion,
    DbTypeDateTime
}
