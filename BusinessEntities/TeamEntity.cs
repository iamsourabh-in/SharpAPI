using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class TeamEntity
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public bool Enabled { get; set; }
    }
}
