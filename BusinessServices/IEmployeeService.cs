using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface IEmployeeService
    {
        long Authenticate(string userName, string word);
        IEnumerable<BusinessEntities.EmployeeEntity> GetAllEmployees();
        long CreateEmployee(BusinessEntities.EmployeeEntity employee);
    }
}
