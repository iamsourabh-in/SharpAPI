using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ProjectEntity
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public Nullable<long> LeadId { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public bool Enabled { get; set; }
        public long Status { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public System.DateTime Begin { get; set; }
        public Nullable<long> OwnerEmpId { get; set; }
    }
}
