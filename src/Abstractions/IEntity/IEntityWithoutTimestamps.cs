// 
// IEntityWithoutTimestamps.cs
// 
//   Created: 2022-10-23-04:33:44
//   Modified: 2022-11-13-01:16:17
// 
//   Author: Justin Chase <justin@justinwritescode.com>
//   
//   Copyright © 2022 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
// 

/* 
 * IEntityWithoutTimestamps.cs
 * 
 *   Created: 2022-10-23-04:33:44
 *   Modified: 2022-11-12-09:06:51
 * 
 *   Author: Justin Chase <justin@justinwritescode.com>
 *   
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */ 


using JustinWritesCode.Abstractions;
namespace JustinWritesCode.EntityFrameworkCore.Abstractions;
using JustinWritesCode.Abstractions;
/// <summary>
/// An interface for a database entity without timestamps
/// </summary>
public interface IEntityWithoutTimestamps : IIdentifiable { }
