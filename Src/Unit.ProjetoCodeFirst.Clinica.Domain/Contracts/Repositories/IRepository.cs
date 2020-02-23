using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Contracts.Repositories
{
    public interface IRepository <TEntity>: IDisposable
        where TEntity : Entity
    {
        IQueryable<TEntity> ObterTodos();
        IQueryable<TEntity> ObterTodosPaginado(int skip, int take);
        IQueryable<TEntity> ObterTodosPaginadoComInclude(int skip, int take, string[] includes);
        IQueryable<TEntity> ObterPor(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> ObterPorComInclude(Expression<Func<TEntity, bool>> predicate, string[] includes);
        IQueryable<TEntity> ObterTodosComInclude(string[] includes);
        TEntity ObterPorId(int id);
        void Inserir(TEntity entity);
        void Atualizar(TEntity entity);
        void Deletar(TEntity entity);
    }
}
