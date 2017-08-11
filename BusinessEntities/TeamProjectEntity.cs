using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class TeamProjectEntity
    {
        public long Id { get; set; }
        public long TeamId { get; set; }
        public long ProjectId { get; set; }
    }
}
