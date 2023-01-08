/*
 * IDbSet{T}.cs
 *
 *   Created: 2023-01-06-05:17:24
 *   Modified: 2023-01-06-05:17:25
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.EntityFrameworkCore.Abstractions;

[GenerateInterfaceAttribute(typeof(DbSet<>))]
public partial interface IDbSet<T> { }
