/*
 * JsonObjectConverter.cs
 *
 *   Created: 2022-12-10-09:00:15
 *   Modified: 2022-12-10-09:00:15
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JustinWritesCode.EntityFrameworkCore;

public class JsonObjectConverter<T> : ValueConverter<T?, string>
{
    public JsonObjectConverter() : base(
        v => Serialize(v, Jso.Default),
        v => Deserialize<T>(v, Jso.Default))
    {
    }
}
