using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DomainModel
{
    public interface IRepository<TEntity>
        where TEntity : Entity
    {
        IQueryable<TEntity> AsQueryable();

        void Add(TEntity entity);

        void AddRange(TEntity[] entities);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
