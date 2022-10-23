//
//  IHaveTimestamps.cs
//
//  Authors:
//       Justin Chase <justin@thebackroom.app>
//       Municipal Drew <drew@wheatleythecat.com>
//
//  Copyright ©️ 2022 The Backroom, Justin Chase, & Municipal Drew
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
namespace JustinWritesCode.EntityFrameworkCore.Abstractions;

public interface IHaveAnUpdatedDate
{
    /// <value>A <see cref="ITimestamp"/> holding the details of the object's last update</value>
    ITimestamp Updated { get; set; }
}
public interface IHaveAnUpdatedDate<TUserId>
{
    /// <value><inheritdoc cref="IHaveAnUpdatedDate.Updated" />  with the ID of the user who performed the operation</value>
    ITimestamp<TUserId> Updated { get; set; }
}
