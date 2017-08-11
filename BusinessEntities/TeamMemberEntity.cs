using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class TeamMemberEntity
    {
        public long Id { get; set; }
        public long TeamId { get; set; }
        public long EmpId { get; set; }
    }
}
