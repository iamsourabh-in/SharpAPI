using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface IAuthorizeService
    {
        bool AuthorizeAccess(string token, string actionOn, string actionType);
    }
}
