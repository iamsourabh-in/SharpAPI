using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CompanyEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string RegistrationNo { get; set; }
        public bool Enabled { get; set; }
        public byte[] Logo { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
    }
}
