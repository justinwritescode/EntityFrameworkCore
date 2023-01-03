//
//  Entity.cs
//
//  Authors:
//       Justin Chase <justin@thebackroom.app>
//       &
//       Municipal Drew <drew@wheatleythecat.com>
//
//  Copyright ©️ 2022 2022 Justin Chase
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace JustinWritesCode.EntityFrameworkCore.Models;
using JustinWritesCode.EntityFrameworkCore.Abstractions;

/// <summary>
/// This is an abstract base class for all Entity Framework entities.
/// </summary>
/// <typeparam name="TId">The type of the ID (primary key) property.</typeparam>
/// <typeparam name="TUserId">The type of the user ID (for the <see cref="ITimestamp{TUserId}"/></typeparam>
public abstract class Entity<TId, TUserId> : Entity<TId>, IEntity<TId, TUserId>, IEquatable<IEntity<TId>>, IComparable<IEntity<TId>>
    where TId : IComparable, IEquatable<TId?>
{
    public new virtual ITimestamp<TUserId> Created { get => (this as IEntity).Created is ITimestamp<TUserId> ituid ? ituid : new Timestamp<TUserId> { By = default, When = (this as IEntity).Created.When, Details = (this as IEntity).Created.Details }; set => (this as IEntity).Created = value; }
    public new virtual ITimestamp<TUserId> Updated { get => (this as IEntity).Created is ITimestamp<TUserId> ituid ? ituid : new Timestamp<TUserId> { By = default, When = (this as IEntity).Updated.When, Details = (this as IEntity).Updated.Details }; set => (this as IEntity).Updated = value; }
    public new virtual ITimestamp<TUserId>? Deleted
    {
        get => (this as IEntity).Deleted == default ?
                default :
                (this as IEntity).Deleted is ITimestamp<TUserId> ituid ?
                ituid :
            new Timestamp<TUserId> { By = default, When = (this as IEntity).Deleted?.When ?? default, Details = (this as IEntity).Deleted.Details };
        set => (this as IEntity).Deleted = value;
    }
}
