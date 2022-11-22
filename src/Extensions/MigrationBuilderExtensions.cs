// 
// MigrationBuilderExtensions.cs
// 
//   Created: 2022-10-31-08:10:54
//   Modified: 2022-10-31-08:10:54
// 
//   Author: Justin Chase <justin@justinwritescode.com>
//   
//   Copyright © 2022 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
// 

using System.Reflection;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JustinWritesCode.EntityFrameworkCore.Extensions;

public static class MigrationBuilderExtensions
{
    static readonly Assembly Assembly = Assembly.GetExecutingAssembly();
    static readonly string AssemblyLocation = Assembly.Location;
    static readonly string AssemblyDirectory = System.IO.Path.GetDirectoryName(AssemblyLocation);
    public static MigrationBuilder InjectSqlFromFile<T>(this MigrationBuilder migrationBuilder, string sqlFileName)
    {
        var sql = File.ReadAllText(Path.Combine(Path.GetDirectoryName(typeof(T).Assembly.Location), sqlFileName));
        migrationBuilder.Sql(sql);
        return migrationBuilder;
    }

	public static MigrationBuilder InjectSqlFromResource<T>(this MigrationBuilder migrationBuilder, string sqlResourceName)
	{
		using var stream = typeof(T).Assembly.GetManifestResourceStream(sqlResourceName);
		using var reader = new StreamReader(stream);
		var sql = reader.ReadToEnd();
		migrationBuilder.Sql(sql);
		return migrationBuilder;
	}
}
