using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DomainModel
{
    public class EntityNotFoundException<TEntity> : DomainException
        where TEntity : Entity
    {
        public EntityNotFoundException()
             : base(string.Format("Entidade '{0}' não encontrada.\n({1})", typeof(TEntity).Name, typeof(TEntity).Namespace))
        {

        }

        public EntityNotFoundException(string message)
            : base(message)
        {

        }
    }
}
