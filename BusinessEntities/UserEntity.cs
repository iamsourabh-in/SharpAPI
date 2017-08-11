using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class UserEntity
    {
       public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UpdatedBy { get; set; }
        public string Position { get; set; }
        public string Reference { get; set; }
        public string Mobile { get; set; }
    }
}
