using System;
using System.Collections.Generic;
//using System.DomainModel.Audit;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.DomainModel
{
    /// <summary>
    /// Raiz de agregado.<para/>
    /// <see cref="http://martinfowler.com/bliki/DDD_Aggregate.html"/>
    /// </summary>
    public abstract class AggregateRoot : Entity //, IAuditableEntity
    {
        public DateTime CreatedOn { get; private set; }

        public string CreatedBy { get; private set; }

        public DateTime ModifiedOn { get; private set; }

        public string ModifiedBy { get; private set; }

        public AggregateRoot()
        {

        }

        //void IAuditableEntity.SetCreated(DateTime on, string by)
        //{
        //    CreatedOn = on;

        //    CreatedBy = by;
        //}

        //void IAuditableEntity.SetModified(DateTime on, string by)
        //{
        //    ModifiedOn = on;

        //    ModifiedBy = by;
        //}
    }
}
