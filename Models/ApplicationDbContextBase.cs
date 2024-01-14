using CampusCoin.Models;
using CampusCoin.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CampusCoin.Models
{
    public abstract class ApplicationDbContextBase : DbContext, IApplicationDbContextBase
    {
       
        protected readonly DateTime _dateTime;

        public ApplicationDbContextBase(DbContextOptions options) : base(options)
        {
        }

        public  override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "";
                        entry.Entity.Created = _dateTime;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = "";
                        entry.Entity.LastModified = _dateTime;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected  override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
