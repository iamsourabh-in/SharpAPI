using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class EpicEntity
    {
        public long Id { get; set; }
        public long ProjectId { get; set; }
        public string Title { get; set; }
        public bool Enabled { get; set; }
        public int Priority { get; set; }
        public long Status { get; set; }
        public Nullable<System.DateTime> Scheduled { get; set; }
        public int Completion { get; set; }
        public string Description { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<long> OwnerEmpId { get; set; }
    }
}
