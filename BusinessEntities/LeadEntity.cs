using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class LeadEntity
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public string Alias { get; set; }
        public bool Enabled { get; set; }
        public Nullable<long> OwnerEmpID { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
    }
}
