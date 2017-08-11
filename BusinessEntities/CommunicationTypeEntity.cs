using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CommunicationTypeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeCode { get; set; }
        public bool Enabled { get; set; }
        public System.DateTime Created { get; set; }
    }
}
