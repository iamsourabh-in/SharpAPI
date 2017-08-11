using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class FeatureAuditLogEntity
    {
        public long Id { get; set; }
        public long FeatureId { get; set; }
        public string Action { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<long> CreatedBy { get; set; }
    }
}
