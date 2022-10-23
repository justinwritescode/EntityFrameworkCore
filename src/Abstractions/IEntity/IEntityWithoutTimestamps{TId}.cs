//
//  IHaveAnId.cs
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
namespace JustinWritesCode.EntityFrameworkCore.Abstractions
{
    /// <summary>
    /// <inheritdoc  cref="IEntityWithoutTimestamps" />
    /// </summary>
    /// <typeparam name="TId">The type of the entity's primary key (named "<see cref="IHaveAnId{TId}.Id"/>")</typeparam>
    public interface IEntityWithoutTimestamps<TId> : IEntityWithoutTimestamps, IHaveAnId<TId>, IHaveAWritableId<TId>, IEquatable<IEntityWithoutTimestamps>, IComparable<IEntityWithoutTimestamps>, IComparable
         where TId : IComparable, IEquatable<TId>
    {

    }
}
