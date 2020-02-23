using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly DbSet<TEntity> _dbSet;
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

        public void Inserir(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public IQueryable<TEntity> ObterPor(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public IQueryable<TEntity> ObterPorComInclude(Expression<Func<TEntity, bool>> predicate, string[] includes)
        {
            var result = _dbSet.Where(predicate);

            foreach (var include in includes)
            {
                result.Include(include);
            }
            return result;
        }

        public TEntity ObterPorId(int id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<TEntity> ObterTodos()
        {
            return _dbSet;
        }

        public IQueryable<TEntity> ObterTodosComInclude(string[] includes)
        {
            var result = _dbSet;
            foreach(var include in includes)
            {
                result.Include(include);
            }
            return result;
        }

        public IQueryable<TEntity> ObterTodosPaginado(int skip, int take)
        {
            return _dbSet.Skip(skip).Take(take);
        }

        public IQueryable<TEntity> ObterTodosPaginadoComInclude(int skip, int take, string[] includes)
        {
            var result = _dbSet.Skip(skip).Take(take);
            foreach (var include in includes)
            {
                result.Include(include);
            }
            return result;

        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
