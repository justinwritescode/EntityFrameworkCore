//
//  IEntity{TId}.cs
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
    /// <inheritdoc cref="IEntity" />
    /// <typeparam name="TId"><inheritdoc cref="IEntityWithoutTimestamps{TId}"/></typeparam>
    public interface IEntity<TId> : IEntityWithoutTimestamps<TId>, IEntity where TId : IComparable, IEquatable<TId>
    {
    }
}
