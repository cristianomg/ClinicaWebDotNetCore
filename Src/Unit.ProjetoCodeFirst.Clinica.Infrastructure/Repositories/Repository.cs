using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Unit.ProjetoCodeFirst.Clinica.Domain.Contracts.Repositories;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;
using Unit.ProjetoCodeFirst.Clinica.Infrastructure.Context;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Repositories
{
    public abstract class Repository <TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        private readonly ClinicaDbContext _db;
        private DbSet<TEntity> _dbSet;
        public Repository(ClinicaDbContext dbContext)
        {
            _db = dbContext;
            _dbSet = _db.Set<TEntity>();
        }

        public void Atualizar(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public void Deletar(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public TEntity Inserir(TEntity entity)
        {

            return null;
        }

        public ICollection<TEntity> ObterPor(Expression<Func<TEntity, bool>> predicate)
        {
            return null;
        }

        public TEntity ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<TEntity> ObterTodos()
        {
            throw new NotImplementedException();

        }

        public ICollection<TEntity> ObterTodosPaginado(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
