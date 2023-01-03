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
public abstract class Entity : IEntity, IEquatable<Entity>
{
    public virtual object Id { get; set; }
    public virtual ITimestamp Created { get; set; } = new Timestamp();
    public virtual ITimestamp Updated { get; set; } = new Timestamp();
    public virtual ITimestamp? Deleted { get; set; } = default;

    public bool Equals(Entity other) => GetType().IsAssignableFrom(other.GetType()) && Id.Equals(other.Id);

    public override int GetHashCode() => GetType().GetHashCode() ^ Id.GetHashCode();
}
