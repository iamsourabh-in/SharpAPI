using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface ICompanyService
    {
        CompanyEntity GetCompanyById(long companyId);
        IEnumerable<CompanyEntity> GetAllCompany();
        long CreateCompany(CompanyEntity companyEntity);
        bool UpdateCompany(long companyId, CompanyEntity companyEntity);
        bool DeleteCompany(long companyId);
    }
}
