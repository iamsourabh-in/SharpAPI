using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class TokenEntity
    {
        public long TokenId { get; set; }
        public long EmpId { get; set; }
        public string AuthToken { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Expiry { get; set; }
    } 
}
