using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class TaskProgressEntity
    {
        public long Id { get; set; }
        public long TaskId { get; set; }
        public int Progress { get; set; }
        public string Comment { get; set; }
        public System.DateTime Dated { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<long> CreatedBy { get; set; }
    }
}
