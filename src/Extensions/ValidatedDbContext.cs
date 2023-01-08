/*
 * ValidatedDbContext.cs
 *
 *   Created: 2022-12-31-06:22:28
 *   Modified: 2022-12-31-06:22:29
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.EntityFrameworkCore;

public class ValidatedDbContext : DbContext
{
    public ValidatedDbContext(DbContextOptions options) : base(options)
    {
    }

    public override int SaveChanges()
    {
        Validate();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        Validate();
        return base.SaveChangesAsync(cancellationToken);
    }

    protected virtual void Validate()
    {
        var changedEntities = ChangeTracker
            .Entries()
            .Where(_ => _.State == EntityState.Added ||
                        _.State == EntityState.Modified);

        var errors = new List<ValidationResult>(); // all errors are here
        foreach (var e in changedEntities)
        {
            var vc = new ValidationContext(e.Entity, null, null);
            Validator.TryValidateObject(
                e.Entity, vc, errors, validateAllProperties: true);
        }

        if (errors.Any())
        {
            throw new DbEntityValidationException(
                "Validation failed for one or more entities.",
                errors);
        }
    }
}
