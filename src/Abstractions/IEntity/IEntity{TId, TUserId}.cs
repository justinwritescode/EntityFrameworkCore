//
//  IEntity{TId, TUserId}.cs
//
//  Authors:
//       Justin Chase <justin@thebackroom.app>
//       &
//       Municipal Drew <drew@wheatleythecat.com>
//
//  Copyright ©️ 2022 Justin Chase
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

namespace JustinWritesCode.EntityFrameworkCore.Abstractions
{
    /// <summary>
    /// <inheritdoc cref="IEntity" />
    /// </summary>
    /// <typeparam name="TId"><inheritdoc cref="IEntity{TId}"/></typeparam>
    /// <typeparam name="TUserId">The type of the user ID</typeparam>
    public interface IEntity<TId, TUserId> : IEntity<TId> where TId : IComparable, IEquatable<TId>
    {
        /// <value>A <see cref="ITimestamp{TUserId}"/> holding the details of the entity's creation</value>
        new ITimestamp<TUserId> Created { get; set; }
        /// <value>A <see cref="ITimestamp{TUserId}"/> holding the details of the entity's last update</value>
        new ITimestamp<TUserId> Updated { get; set; }
        /// <value>A <see cref="ITimestamp{TUserId}?"/> holding the details of the entity's deletion (if applicable, <see langword="null"/>/<see langword="default"/> otherwise)</value>
        new ITimestamp<TUserId>? Deleted { get; set; }
    }
}
