using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessServices
{
    public interface IUserServices
    {
        int Authenticate(string userName, string word);
        IEnumerable<BusinessEntities.UserEntity> GetAllUsers();
        int CreateUser(BusinessEntities.UserEntity user);
    }
}
