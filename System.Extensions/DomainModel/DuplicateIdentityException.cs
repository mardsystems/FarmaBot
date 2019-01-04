using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DomainModel
{
    public class DuplicateIdentityException<TEntity> : DomainException
        where TEntity : Entity
    {
        public DuplicateIdentityException()
            : base(string.Format("Entidade '{0}' já existe.\n({1})", typeof(TEntity).Name, typeof(TEntity).Namespace))
        {

        }
    }
}
