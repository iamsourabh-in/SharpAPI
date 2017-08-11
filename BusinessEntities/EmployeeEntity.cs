using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class EmployeeEntity
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Alias { get; set; }
        public string EmployeeCode { get; set; }
        public bool Enabled { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string Password { get; set; }
    }
}
