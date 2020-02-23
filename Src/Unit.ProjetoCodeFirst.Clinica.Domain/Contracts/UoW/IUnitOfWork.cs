using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
