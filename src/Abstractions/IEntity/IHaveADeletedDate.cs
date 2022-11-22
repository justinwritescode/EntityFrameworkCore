/*
 * IHaveADeletedDate.cs
 *
 *   Created: 2022-10-23-04:33:44
 *   Modified: 2022-11-12-07:14:40
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.EntityFrameworkCore.Abstractions;

public interface IDeletable
{
    /// <value>A <see cref="ITimestamp" /> holding the details of the object's deletion (if applicable, <see langword="null"/>/<see langword="default"/> otherwise)</value>
    ITimestamp? Deleted { get; set; }
}
public interface IDeletable<TUserId>
{
    /// <value><inheritdoc cref="IDeletable.Deleted" />  with the ID of the user who performed the operation</value>
    ITimestamp<TUserId> Deleted { get; set; }
}
