using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DomainModel
{
    public abstract class Entity
    {
        private byte[] version;

        public byte[] Version
        {
            get { return version; }
            set
            {
                // Ignora.
            }
        }

        public Entity()
        {
            version = new byte[] { 0 };
        }
    }
}
