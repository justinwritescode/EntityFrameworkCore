/*
 * ValidatedDbContext.cs
 *
 *   Created: 2022-12-31-06:22:28
 *   Modified: 2022-12-31-06:22:29
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.EntityFrameworkCore;

public class DbEntityValidationException : Exception
{
    public DbEntityValidationException(string message, List<ValidationResult> errors) : base(message)
    {
        Errors = errors;
    }

    public List<ValidationResult> Errors { get; }
}
