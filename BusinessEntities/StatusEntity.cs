using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class StatusEntity
    {
        public long Id { get; set; }
        public Nullable<long> CompanyId { get; set; }
        public string Value { get; set; }
        public string ValueFor { get; set; }
    }
}
