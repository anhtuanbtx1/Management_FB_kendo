using System;
using System.Collections.Generic;

namespace PSafe.Core.SharedKernel
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
       
    }
}
