using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class PermissionEntity
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public int EntityId { get; set; }
        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
        public bool Remove { get; set; }
        public bool Enabled { get; set; }
        public System.DateTime Created { get; set; }
        public long CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public long ModifiedBy { get; set; }
    }
}
