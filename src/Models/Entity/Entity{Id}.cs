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

using JustinWritesCode.Abstractions;
using JustinWritesCode.EntityFrameworkCore.Abstractions;

/// <summary>
/// This is an abstract base class for all Entity Framework entities.
/// </summary>
/// <typeparam name="TId">The type of the ID (primary key) property.</typeparam>
public abstract class Entity<TId> : EntityWithoutTimestamps<TId>
    where TId : IComparable, IEquatable<TId>
{
    public virtual TId Id { get => (TId)((IIdentifiable)this).Id; set => ((IHaveAWritableId)this).Id = value; }

    public virtual ITimestamp Created { get; set; } = new Timestamp();
    public virtual ITimestamp Updated { get; set; } = new Timestamp();
    public virtual ITimestamp? Deleted { get; set; } = default(Timestamp);
    public virtual int CompareTo(IEntity<TId>? other) => Id.CompareTo(other == default ? default : (other as IIdentifiable<TId>).Id);
    public virtual bool Equals(IEntity<TId>? other) => Id.Equals(other == default ? default : (other as IIdentifiable<TId>).Id);
    public virtual int CompareTo(IEntity? other) => CompareTo(other == default ? default : other as IEntity<TId>);
    public bool Equals(IEntity? other) => this.Id?.Equals(other?.Id) ?? false;
}
