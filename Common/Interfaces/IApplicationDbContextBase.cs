using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CampusCoin.Common.Interfaces
{
    public interface IApplicationDbContextBase
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
