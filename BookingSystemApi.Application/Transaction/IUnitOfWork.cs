using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Transaction
{
    public interface IUnitOfWork
    {
        void SaveChanges(CancellationToken cancellationToken);
        void Commit();
        void Rollback();
        void BeginTransaction(IsolationLevel isolationLevel);
    }
}
