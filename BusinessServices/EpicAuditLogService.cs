using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class EpicAuditLogService : IEpicAuditLogService
    {

        public BusinessEntities.EpicAuditLogEntity GetEpicAuditLogById(long companyId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BusinessEntities.EpicAuditLogEntity> GetAllEpicAuditLog()
        {
            throw new NotImplementedException();
        }

        public long CreateCompany(BusinessEntities.EpicAuditLogEntity epicAuditLogEntity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCompany(long epicAuditLogId, BusinessEntities.EpicAuditLogEntity epicAuditLogEntity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCompany(long epicAuditLogId)
        {
            throw new NotImplementedException();
        }
    }
}
