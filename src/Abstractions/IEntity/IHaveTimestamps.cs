/*
 * IHaveTimestamps.cs
 *
 *   Created: 2022-10-23-04:33:44
 *   Modified: 2022-11-12-09:06:09
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */


using System;
namespace JustinWritesCode.EntityFrameworkCore.Abstractions;

public interface ITimestampable<TUserId> : ICreatable<TUserId>, IUpdatable<TUserId>, IDeletable<TUserId> { }
