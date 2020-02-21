using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Contracts.Repositories
{
    public interface IRepository <TEntity>: IDisposable
        where TEntity : Entity
    {
        ICollection<TEntity> ObterTodos();
        ICollection<TEntity> ObterTodosPaginado(int skip, int take);
        ICollection<TEntity> ObterPor(Expression<Func<TEntity, bool>> predicate);
        TEntity ObterPorId(int id);
        TEntity Inserir(TEntity entity);
        void Atualizar(TEntity entity);
        void Deletar(TEntity entity);
    }
}
