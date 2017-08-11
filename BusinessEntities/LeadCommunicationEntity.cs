using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class LeadCommunicationEntity
    {
        public long Id { get; set; }
        public int CommunicationTypeId { get; set; }
        public string Value { get; set; }
        public bool DefaultEmail { get; set; }
        public bool DefaultMobile { get; set; }
        public bool DefaultAddress { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
    }
}
