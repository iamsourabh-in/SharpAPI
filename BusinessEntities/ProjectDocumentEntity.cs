using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ProjectDocumentEntity
    {
        public long Id { get; set; }
        public long ProjectId { get; set; }
        public byte[] Data { get; set; }
        public string Note { get; set; }
        public string FileXtention { get; set; }
        public string FileName { get; set; }
        public bool Rejected { get; set; }
        public long OwnerEmpID { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
    }
}
